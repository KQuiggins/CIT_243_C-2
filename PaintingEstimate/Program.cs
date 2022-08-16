using System;
using static System.Console;
using System.Globalization;
class PaintingEstimate
{
    static void Main()
    {
        Write("What is the length of the room? ");
        int length = int.Parse(ReadLine());
        Write("What is the width of the room? ");
        int width = int.Parse(ReadLine());

        // Call Method
        double totalPrice = ComputeCost(length, width);

        WriteLine("The total price of the room is {0}", totalPrice.ToString("C", CultureInfo.GetCultureInfo("en-US")));

    }

    public static double ComputeCost(int length, int width)
    {
        // Price per square foot
        int price = 6;
        // Ceiling
        int ceiling = 9;

        int totalSquare = width * ceiling * 2 + length * ceiling * 2;

        return price * totalSquare;
    }
}
