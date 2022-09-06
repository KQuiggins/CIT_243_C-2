using System;
using static System.Console;
using System.Globalization;
class SalesTransactionDemo
{


  
    
   static void Main()
   {
        SalesTransaction sale1 = new SalesTransaction("Joe", 200.50, 20.00);
        SalesTransaction sale2 = new SalesTransaction("Ellen", 15.99);
        SalesTransaction sale3 = new SalesTransaction("Sue");
        
        
   }
   public static void Display(SalesTransaction s)
   {
         WriteLine($"{s.Name} {s.salesAmount.ToString("C", CultureInfo.CurrentCulture)} {s.commission.ToString("C", CultureInfo.CurrentCulture)} {s.getRate().ToString("P", CultureInfo.CurrentCulture)}");
         
   }

   public static void DisplayTotal(SalesTransaction s)
   {
        WriteLine($"Total Sales: {s.salesAmount.ToString("C", CultureInfo.CurrentCulture)}");
   }
}

class SalesTransaction
{
    public double salesAmount {get; set;}
    public string Name {get; set;}
    public double commission {get; set;}
    readonly double RATE;
    
    public double getRate()
    {
        return RATE;
    }
    
    public static SalesTransaction operator+(SalesTransaction st1, SalesTransaction st2)
    {
        double newSalesAmount = st1.salesAmount + st2.salesAmount;
        return (new SalesTransaction(newSalesAmount));
    }
    
    public SalesTransaction(string name, double salesAmount, double rate)
    {
        Name = name;
        this.salesAmount = salesAmount;
        RATE = rate;
        commission = salesAmount * rate;
    }
    
    
     public SalesTransaction(string name, double salesAmount)
    {
        Name = name;
        this.salesAmount = salesAmount;
        RATE = 0;
    }
    
    public SalesTransaction(string name)
    {
        Name = name;
        salesAmount = 0;
        RATE = 0;
        commission = 0;
    }
}


/* Create an application named that declares several SalesTransaction objects and displays their values and their sum  */

/* Class contains the following fields:

Name: string
salesAmount: double
commission: double
RATE: readonly (stores commission rate as a double.) Define a getRate() accessor method that returns the RATE.
WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));
 */