using System;
using static System.Console;
class RelativesList
{
   static void Main()
   {
      Relative[] relArr = new Relative[12];
      int x;
        for (x = 0; x < relArr.Length; x++)
        {
            WriteLine("Relative {0};", x+1);
            relArr[x] = new Relative();
            WriteLine("Relative's Name: ");
            relArr[x].Name = ReadLine();
            WriteLine("Relationship to you:");
            relArr[x].Relationship = ReadLine();
            WriteLine("Birth Day: ");
            relArr[x].Day = int.Parse(ReadLine());
            WriteLine("Birth Month: ");
            relArr[x].Month = int.Parse(ReadLine());
            WriteLine("Birth Year: ");
            relArr[x].Year = int.Parse(ReadLine());
        }
        Array.Sort(relArr);
        WriteLine("Sorted Relative's List: ");
        for (x = 0; x < relArr.Length; x++)
        {
            WriteLine("{0,-25}{1,-25}{2}/{3}/{4}", relArr[x].Name, relArr[x].Relationship, relArr[x].Day, relArr[x].Month, relArr[x].Year);
        }

   }
}

class Relative : IComparable
{
   public string Name {get; set;}
   public string Relationship {get; set;}
   public string Birthday {get; set;}
   public int Month { set; get; }
   public int Day { set; get; }
   public int Year { set; get; }
   
   
   
}




/* Create a program named RelativesList that declares an array of at least 12 relative objects and prompts the user to enter data about them.

The Relative class includes auto-implemented properties for the following:

    Name - Relative’s name
    Relationship - relationship to you (for example, aunt)
    Include three integers (Month, Day, Year) that together represent the Relative’s birthday -- month, day, and year

Display the Relative objects in alphabetical order by first name, as shown below:

...
Joe            Brother        8/4/2000
Joey           Brother        5/8/2004
Josefina       Sister         2/22/2008
Joseph         Brother        10/10/2012
...
 */

/* Array.Sort(relArr);
WriteLine("Sorted Relative's List: ");
for (x = 0; x < relArr.Length; x++)
{
    WriteLine("{0,-25}{1,-25}{2}/{3}/{4}", relArr[x].Name, relArr[x].Relationship, relArr[x].Day, relArr[x].Month, relArr[x].Year);
} */