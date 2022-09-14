using static System.Console;
using System.Reflection;
using System.Collections.Generic;


class PracticeCode
{
    public int IDNum {get; set;}
    public string Name {get; set;}
    static void Main()
    {
        Name = "Kenny";
        IDNum = 1;
        WriteLine(ToString());
    }

    public override string ToString()
    {
        return($"{Name} : {IDNum}");
    }
}