using System;
using static System.Console;
using System.Globalization;
class MarshallsRevenue
{
   static void Main()
   {
      // Write your main here.
   }
   public static int GetMonth()
   {
      // Write your GetMonth() method here.
   }
   public static int GetNumMurals(string location)
   {
      // Write your GetNumMurals() method here.
   }
   public static int ComputeRevenue(int month, int numInterior, int numExterior)
   {
      // Write your ComputeRevenue() method here.
   }
   public static void DataEntry(string location, int num, string[] customers, char[] muralCodes, string[] muralCodesStrings, char[] codes, int[] counts)
   {
      // Write your DataEntry() method here.
   }
   public static void GetSelectedMurals(char[] muralCodes, string[] muralCodesStrings, int numInterior, int numExterior, string[] interiorCustomers, char[] interiorCodes, string[] exteriorCustomers, char[] exteriorCodes)
   {
      // Write your GetSelectedMurals() method here.
   }    

}


    /* GetMonth - This method prompts for and returns the month
    GetNumMurals - This method prompts for and returns the number of murals scheduled and is called twice -- once for interior murals and once for exterior murals
    ComputeRevenue - This method accepts the number of interior and exterior murals scheduled, accepts the month they are scheduled, displays the interior and exterior prices, and then returns the total expected revenue
    DataEntry - This method fills an array with customer names and mural codes and is called twice -- once to fill the array of interior murals and once to fill the array of exterior murals
    GetSelectedMurals - This method continuously prompts for mural codes and displays jobs of the corresponding type until a sentinel value is entered. */

/* In order to prepend the $ to currency values, the program will need to use the CultureInfo.GetCultureInfo method. In order to do this, include the statement using System.Globalization; at the top of your program and format the output statements as follows: WriteLine("This is an example: {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US"))); */
