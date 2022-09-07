using System;
using static System.Console;
using System.Globalization;
class SalesTransactionDemo
{
   static void Main()
   {
        SalesTransaction sale1 = new SalesTransaction("Joe", 200.50, 0.2);
        SalesTransaction sale2 = new SalesTransaction("Ellen", 15.99);
        SalesTransaction sale3 = new SalesTransaction("Sue");
        Display(sale1);
        Display(sale2);
        Display(sale3);
        DisplayTotal(sale1);
        DisplayTotal(sale2);
        DisplayTotal(sale3);
   }
   public static void Display(SalesTransaction s)
   {
        WriteLine($"{s.Name} {s.salesAmount} {s.getRate()}");
   }
   public static void DisplayTotal(SalesTransaction s)
   {
        WriteLine($"s.salesAmount");
   }
}

class SalesTransaction
{
  
  
  public double SalesAmount;
  public double Commission;
  public string name;
  
  public string Name {get; set;}
  public double salesAmount {get; set;}
  public double commission {get; set;} 
  readonly double RATE;

  

  

  


  

  public SalesTransaction(string name, double salesAmount, double rate)
  {
    Name = name;
    SalesAmount = salesAmount;
    RATE = rate;
    Commission = SalesAmount * RATE;
    

  }

  public SalesTransaction(string name, double salesAmount) : this(name, salesAmount,0)
  {

  }

  public SalesTransaction(string name) : this(name,0,0)
  {

  }

  public static SalesTransaction operator +(SalesTransaction st1, SalesTransaction st2)
  {
    string combineNames;
    double totalSalesAmount;
    combineNames = st1.Name + st2.Name;
    totalSalesAmount = st1.SalesAmount + st2.SalesAmount;

    return(new SalesTransaction(combineNames, totalSalesAmount));
  }

  public double getRate()
  {
    return RATE;
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