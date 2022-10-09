using System;
using static System.Console;
class SwimmingWaterTemperature
{
   static void Main()
   {
       
       Write("\nPlease enter the water temperature in degrees Fahrenheit: ");
       while (true)
        {
            
            
            try
            {
                int temp = (ReadLine());
                if (temp == 999) {break;}
                else if (CheckComfort(temp) == true)
                {  // Call the method to check if it's true/false (comfortable for swimming) 
                    Write(temp + " degrees is comfortable for swimming.\n");
                }
                else if (CheckComfort(temp) == false)
                {
                    Write(temp + " degrees is not comfortable for swimming.\n");
                }
                
                Write("Please enter another temperature or 999 to quit: ");

            }
            catch (ApplicationException ex)
            {
                WriteLine("Value does not fall within the expected range.");
                WriteLine(ex.ToString());
            }
        }
   }
    
    public static Boolean CheckComfort(int temp) {

        
        
        if (temp >= 70 && temp <= 85)
        {
            return true;
        }
        else if(temp >= 32 && temp <= 212)
        {
            return false;
        }
        
       
        

    }

}
