using System;
using static System.Console;

public class InputMethodDemoTwo
{
    public static void Main()
    {
        int first, second;

        InputMethod(out first, out second);
        WriteLine($"After InputMethod first is {first} and second is {second}");
        ReadLine();
    }

    public static void InputMethod(out int first, out int second)
    {
        first = DataEntry("first");
        second = DataEntry("second");
    }

    public static int DataEntry(string whichOne)
    {
        Write($"Enter {whichOne} integer: ");
        if (!int.TryParse(ReadLine(), out int data))
        {
            WriteLine("Invalid input. Please try again.");
            return DataEntry(whichOne);
        }
        return data;
    }
}