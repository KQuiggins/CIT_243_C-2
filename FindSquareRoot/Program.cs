using static System.Console;

internal class Program
{


    private static void Main(string[] args)
    {


        try
        {
            double sqrt = 0;
            double num1 = 0;

            Write("Enter a number ");
            num1 = Convert.ToDouble(ReadLine());
            if (num1 > 0)
            {
                sqrt = Math.Sqrt(num1);
                WriteLine($"Square root of {num1} is {sqrt}");
            }
            else if (num1 <= 0)
            {
                sqrt = 0;
                throw new ApplicationException("Number can't be negative.");

            }
        }
        catch (FormatException error)
        {
            WriteLine("Number can not be converted to double");
            WriteLine(error.Message);


        }
        catch(ApplicationException error)
        {
            WriteLine(error.Message);
        }
    }
}