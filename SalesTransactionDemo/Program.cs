using System;
using static System.Console;
using System.Globalization;
class SalesTransactionDemo
{


  
    
   static void Main()
   {
     SalesTransaction sale1 = new SalesTransaction("Joe", 200.50, .2033);
    SalesTransaction sale2 = new SalesTransaction("Ellen", 15.99);
    SalesTransaction sale3 = sale1 + sale2;
    WriteLine("{0} {1}", sale3.Name, sale3.SalesAmount);
        
   }
   public static void Display(SalesTransaction s)
   {
         WriteLine("{0} {1}", s.Name, s.SalesAmount, );
         
   }

   public static void DisplayTotal(SalesTransaction s)
   {
        
   }
}

class SalesTransaction
{
    public double salesAmount {get; set;}
    public string Name {get; set;}
    public double Commission {get; set;}
    public double RATE {get; set;}
    
    public double getRate()
    {
        return RATE;
    }
    
    public static SalesTransaction operator+(SalesTransaction st1, SalesTransaction st2)
    {
        double newSalesAmount = st1.SalesAmount + st2.SalesAmount;
        return (new SalesTransaction("total", newSalesAmount));
    }
    
    public SalesTransaction(string name, double salesAmount, double rate)
    {
        Name = name;
        SalesAmount = salesAmount;
        RATE = rate;
        Commission = salesAmount * rate;
    }
    
    
     public SalesTransaction(string name, double salesAmount)
    {
        Name = name;
        SalesAmount = salesAmount;
        RATE = 0;
    }
    
    public SalesTransaction(string name)
    {
        Name = name;
        SalesAmount = 0;
        RATE = 0;
        Commission = 0;
    }
}


/* Create an application named that declares several SalesTransaction objects and displays their values and their sum  */

/* Class contains the following fields:

Name: string
salesAmount: double
commission: double
RATE: readonly (stores commission rate as a double.) Define a getRate() accessor method that returns the RATE
 */