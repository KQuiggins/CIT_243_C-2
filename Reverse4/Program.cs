using static System.Console;
class Reverse4
{
   static void Main()
   {
        int number1 = 23;
        int number2 = 45;
        int number3 = 55;
        int number4 = 67;

        WriteLine("Before:");
        WriteLine($"{number1} {number2} {number3} {number4}");
        

        
        WriteLine("After:");
        Reverse(ref number1, ref number2, ref number3, ref number4);
        WriteLine($"{number1} {number2} {number3} {number4}");
   }

   public static void Reverse(ref int a, ref int b,
      ref int c, ref int d)
   {
        
        int temp1;
        temp1 = a;
        a = d;
        d = temp1;

        int temp2;
        temp2 = b;
        b = c;
        c = temp2;
        
        
        
        
        
   }

}
