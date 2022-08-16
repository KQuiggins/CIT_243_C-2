using static System.Console;

public class SalesLetter
{
    public static void Main()
    {
        WriteLine("From");
        DisplayContactInfo();
        WriteLine();
        WriteLine("-------------------------");
        WriteLine();
        WriteLine("Dear Client,");
        WriteLine("Thank you for being a part of kenstech.");
        DisplayContactInfo();
        WriteLine();
        WriteLine("******************************");
        WriteLine();
        WriteLine("Looking forward to the business we have with you.");
        DisplayContactInfo();

    }
    public static void DisplayContactInfo()
    {
        string business = "kens tech";
        string phone = "555 - 5555";
        string email = "kenstech@tech.com";
        string webpage = "www.kenstech.com";
        
        
        
        WriteLine($"{business}");
        WriteLine($"Phone: {phone}");
        WriteLine($"Email: {email}");
        WriteLine($"Visit our webpage at {webpage}");
    }
}