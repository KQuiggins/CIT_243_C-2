using static System.Console;
using System.Reflection;
using System.Collections.Generic;




int num = 13, denom = 0, result;
int[] array = {22, 13, 44};
bool isGoodItem = false;
WriteLine(!isGoodItem);


try
{
    result = num / denom;
    result = array[num];
}

catch(DivideByZeroException error)
{
    WriteLine("In the first catch block: ");
    WriteLine(error.Message);

}
catch(IndexOutOfRangeException error)
{
    WriteLine("In the second catch block: ");
    WriteLine(error.Message);
    WriteLine(error.StackTrace);

}

    
