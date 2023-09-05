using System;
using static System.Console;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

try
{
    Divide();
}
catch (DivideByZeroException)
{
    WriteLine("Can't divide by zero");
}

static void Divide()
{
    WriteLine("Enter a number: ");
    double dividend = Convert.ToDouble(ReadLine());
    double divisor;
    do
    {
        WriteLine("Enter another number (cannot be zero): ");
        divisor = Convert.ToDouble(ReadLine());
    } while (divisor == 0);
    double result = dividend / divisor;
    WriteLine("{0} divided by {1} is {2}",
        dividend, divisor, result);
}







