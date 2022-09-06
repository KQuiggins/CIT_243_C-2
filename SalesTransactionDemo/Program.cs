using System;
using static System.Console;
using System.Globalization;
class SalesTransactionDemo
{
    public string Name { get; set; }
    public double salesAmount { get; set; }
    public double commission { get; set; }
    readonly double RATE;

    public static SalesTransactionDemo operator +(SalesTransactionDemo s1, SalesTransactionDemo s2)
    {
        SalesTransactionDemo s3 = new SalesTransactionDemo();
        s3.salesAmount = s1.salesAmount + s2.salesAmount;
        
        return s3;
    }

    



    public SalesTransactionDemo(string name, double salesAmount, double rate)
    {
        Name = name;
        this.salesAmount = salesAmount;
        RATE = rate;
        commission = salesAmount * RATE;
    }

    public SalesTransactionDemo(string name, double salesAmount)
    {
        Name = name;
        this.salesAmount = salesAmount;
        RATE = 0;
    }

    public SalesTransactionDemo(string name)
    {
        Name = name;
        salesAmount = 0;
        RATE = 0;
        commission = 0;
    }

    public double getRate()
    {
        return RATE;
    }


   static void Main()
   {
        SalesTransactionDemo s1 = new SalesTransactionDemo("John", 1000, 0.05);
   }
   public static void Display(SalesTransaction s)
   {
        WriteLine("Name: {0}", s.Name);
        WriteLine("Sales Amount: {0}", s.salesAmount.ToString("C", CultureInfo.CurrentCulture));
        WriteLine("Commission: {0}", s.commission.ToString("C", CultureInfo.CurrentCulture));
        WriteLine("Rate: {0}", s.getRate().ToString("P", CultureInfo.CurrentCulture));
   }
   public static void DisplayTotal(SalesTransaction s)
   {
        WriteLine("Total Sales Amount: {0}", s.salesAmount.ToString("C", CultureInfo.CurrentCulture));
        WriteLine("Total Commission: {0}", s.commission.ToString("C", CultureInfo.CurrentCulture));
   }
}

/* Create an application named that declares several SalesTransaction objects and displays their values and their sum  */

/* Class contains the following fields:

Name: string
salesAmount: double
commission: double
RATE: readonly (stores commission rate as a double.) Define a getRate() accessor method that returns the RATE
 */