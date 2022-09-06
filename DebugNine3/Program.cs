using System;
using static System.Console;
using System.Globalization;
class DebugNine3
{
   static void Main()
   {
      Car myCar = new Car(32000, "red");
      Car yourCar = new Car(14000);
      Car theirCar;
      WriteLine("My {0} car cost {1}", myCar.color,
         myCarr.Price.ToString("c2", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Your {0} car cost {1}",
         yourCar.Color, youRCar.price.Tostring("c2", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Their {0} car cost {1}",
         theirCar.Color, theirCar.price.ToString("c2", CultureInfo.GetCultureInfo("en-US")));
  }
}
class Car
{
   private string color;
   private int price;
   public Car() : this(10000, "black")
   {
   }
   public Car(int price) : this()
   {
   }
   public Car(int price, string color)
   {
       Price = this;
       Color = color;
   }
   public string Color
   {
      get
      {
         return color;
      }
      set
      {
         color = value;
      }
   }
   public int Price
   {
      get
      {
         return Price;
      }
      set
      {
         price = value;
      }
   }
}

