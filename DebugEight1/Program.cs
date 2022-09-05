// GetData() method accepts order number and quantity
// that are used in the Main() method
// Price is $3.99 each
using System;
using static System.Console;
using System.Globalization;
class DebugEight1
{
   static void Main()
   {
      int orderNum, quantity;
      double total;
      const double PRICE_EACH = 3.99;
      GetData( out orderNum, out quantity); // added missing comma
      total = quantity * PRICE_EACH; // fixed spelling error
      WriteLine("Order #{0}. Quantity ordered = {1}",
          orderNum, quantity); // closed writeline statement
      WriteLine("Total is {0}", total.ToString("C", CultureInfo.GetCultureInfo("en-US")));
   }
   public static void GetData(out int order, out int amount) // added int identifier
   {
       string s1, s2; // fixed spelling error
       Write("Enter order number ");
       s1 = ReadLine();
       Write("Enter quantity ");
       s2 = ReadLine();
       order = Convert.ToInt32(s1); // fixed spelling error
       amount = Convert.ToInt32(s2); // fixed spelling error
   } // added end braces for GetData() method
} // added end braces for DebugEight1 class