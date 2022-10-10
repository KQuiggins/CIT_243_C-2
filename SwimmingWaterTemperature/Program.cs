using System;
using static System.Console;
class SwimmingWaterTemperature
{
    static void Main()
    {

        WriteLine("Please enter the water temperature in degrees Fahrenheit: ");
        while (true)
        {


            try
            {
                int temp = Convert.ToInt32(ReadLine());

                if (temp == 999) { break; }

                else if (CheckComfort(temp) == true)
                {  // Call the method to check if it's true/false (comfortable for swimming) 
                    WriteLine($"{temp} degrees is comfortable for swimming.");
                }
                else if (CheckComfort(temp) == false)
                {
                    WriteLine($"{temp} degrees is not comfortable for swimming.");
                }

                WriteLine("Please enter another temperature or 999 to quit: ");

            }
            catch (ApplicationException)
            {
                WriteLine("Value does not fall within the expected range.");
                WriteLine("Enter another temperature or 999 to quit: ");
            }
        }
    }

    public static Boolean CheckComfort(int temp)
    {



        if (temp >= 70 && temp <= 85)
        {
            return true;
        }
        else if (temp >= 32 && temp <= 212)
        {
            return false;
        }
        else{
            throw new ApplicationException();
        }




    }

}
