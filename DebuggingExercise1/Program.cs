// Uses DisplayWebAddress method three times
using static System.Console;
class DebugSeven1
{
   static void Main()
   {
      DisplayWebAddress(); // method call had no parentheses & Address was missing an s
      WriteLine("Shop at Shopper's World"); // L was lowercase L
      DisplayWebAddress(); // method call had no parentheses
      WriteLine("The best bargains from around the world");
      DisplayWebAddress(); // method call had no parentheses
   }
   public static void DisplayWebAddress()
   {
      WriteLine("------------------------------");
      WriteLine("Visit us on the web at:");
      WriteLine("www.shoppersworldbargains.com");
      WriteLine("******************************");
   }
}
