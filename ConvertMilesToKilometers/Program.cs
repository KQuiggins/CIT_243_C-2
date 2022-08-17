using System;
using static System.Console;
class ConvertMilesToKilometers
{
   static void Main()
   {
        Write("What is the distance in miles? ");
        double miles = Convert.ToDouble(ReadLine());
        double kilometers = ConvertToKilometers(miles);
        WriteLine("The distance in kilometers is {0}", kilometers);
   }
   public static double ConvertToKilometers(double miles)
   {
        double kilometers = miles * 1.60934;
        return kilometers; 

   }
}
