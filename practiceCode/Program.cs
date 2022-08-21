using static System.Console;
using System.Reflection;


class PracticeCode
{
    static void Main()
    {
        string applesText = "Apples";
        int applesCount = 1234;
        string bananasText = "Bananas";
        int bananasCount = 56789;
        WriteLine(format: "{0,-5} {1,5}", arg0: applesText, arg1: applesCount);
    }
}