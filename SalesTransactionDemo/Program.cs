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
        SalesTransaction sale4;
        sale4 = sale1 + sale2;
        WriteLine(sale1.salesAmount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        
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
        
        double newSalesAmount;
        newSalesAmount = st1.salesAmount + st2.salesAmount;
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

/*  One constructor accepts values for the name, sales amount, and rate, and when the sales value is set, the constructor computes the commission as sales value times commission rate.

The second constructor accepts a name and sales amount, but sets the commission rate to 0.

The third constructor accepts a name and sets all the other fields to 0.

An overloaded + operator adds the sales values for two SalesTransaction objects and returns a new SalesTransaction object. */