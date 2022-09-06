using System;
using static System.Console;
using System.Globalization;
class DebugNine3
{
   static void Main()
   {
      Car myCar = new Car(32000, "red");
      Car yourCar = new Car(14000);
      Car theirCar = new Car();
      WriteLine("My {0} car cost {1}", myCar.Color,
         myCar.Price.ToString("c2", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Your {0} car cost {1}",
         yourCar.Color, yourCar.Price.ToString("c2", CultureInfo.GetCultureInfo("en-US"))); // fixed spelling
      WriteLine("Their {0} car cost {1}",
         theirCar.Color, theirCar.Price.ToString("c2", CultureInfo.GetCultureInfo("en-US")));
  }
}
class Car
{
   private string color;
   private int price;
   public Car() : this(10000, "black")
   {
   }
   public Car(int price) : this(price, "black") // added price and "black" to this statement
   
   
   {
      Price = price; // swapped Price and price 
   }
   public Car(int price, string color)
   {
       Price = price; // added price to this.price
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
         return price; // fixed spelling
      }
      set
      {
         price = value;
      }
   }
}

