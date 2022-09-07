using System;
using static System.Console;
using System.Globalization;

namespace SalesTransactionDemo;

/* Create an application named that declares several SalesTransaction objects and displays their values and their sum  */

/* Class contains the following fields:

Name: string
salesAmount: double
commission: double
RATE: readonly (stores commission rate as a double.) Define a getRate() accessor method that returns the RATE.
WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));
 */

/*  One constructor accepts values for the name, sales amount, and rate, and when the sales value is set, the constructor computes the commission as sales value times commission rate.

The second constructor accepts a name and sales amount, but sets the commission rate to 0.

The third constructor accepts a name and sets all the other fields to 0.

An overloaded + operator adds the sales values for two SalesTransaction objects and returns a new SalesTransaction object. */

class Program
{
    public static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        var sales = new List<SalesTransaction>()
        {
            new SalesTransaction("Joe", 200.50, 0.2),
            new SalesTransaction("Ellen", 15.99),
            new SalesTransaction("Sue")
        };
        
        sales.Add(sales[0] + sales[1]);

        foreach (var sale in sales)
        {
            WriteLine(sale);
        }

        /*
        Output:
        Joe $200.50 $40.10 20.000%
        Ellen $15.99 $0.00 0.000%
        Sue $0.00 $0.00 0.000%
        Joe+Ellen $216.49 $0.00 0.000%
        */
    }
}