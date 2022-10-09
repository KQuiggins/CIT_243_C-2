// Handles a Format Exception if user does not enter a number
using System;
using static System.Console;
using System.Globalization;


double salary = 0.0;
string salVal;
bool isValidSalary = false; // assigned a value
while (!isValidSalary)
{
    try // wrapped try with curly brackets
    {
        Write("Enter an employee's salary ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        salVal = ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        salary = Convert.ToDouble(salVal);
        isValidSalary = true;
    }
    catch (FormatException) // fixed spelling 
    {
        WriteLine("You must enter a number for the salary.");
    }
}
WriteLine("The salary {0} is valid", salary.ToString("C2", CultureInfo.GetCultureInfo("en-US")));
