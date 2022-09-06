/*Create a program named IntegerFacts who's main method declares an Array of 10 integers.
Call a method named FillArray to interactively fill the array with any number of 
values up to ten or until a sentinel value (999) is entered. If an entry isn't an integer,
re - prompt the user.
Call a second method named Statistics that accepts out parameters for the highest value 
in the array, lowest value in the array, sum of the values in the array, and arithmetic average.
Display the statistics*/

using static System.Console;
class IntegerFacts
{
    static void Main()
    {
        int[] arrayOfTen = new int[10];
        FillArray(arrayOfTen);
    }

    public static int FillArray(int[] array)
    {

    }
    public static void Statistics(int[] array, int els, out int high, out int low, out int sum, out double avg)
    {
    }

}