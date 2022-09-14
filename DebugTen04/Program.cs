// class HotelRoom has child classes SingleRoom which costs less,
// and Suite which costs more
using System;
using static System.Console;
using System.Globalization;
class DebugTen04
{
   static void Main()
   {
      HotelRoom aRoom = new HotelRoom(234);
      SingleRoom aSingle = new SingleRoom(135); 
      Suite aSuite = new Suite(453);
      WriteLine(aRoom.ToString());
      WriteLine(aSingle.ToString());
      WriteLine(aSuite.ToString()); // fixed missing parentheses
   }
}
class HotelRoom
{
   public const double PREMIUM = 30.00;
   public const double STD_RATE = 89.99;
   private int roomNumber;
   protected double rate; 
   public HotelRoom(int room) // removed double room
   {
      roomNumber = room;
      rate = STD_RATE; // changed spelling from STANDARD_RATE to STD_RATE
   }
   public int RoomNumber
   {
      get
      {
         return roomNumber; // changed spelling from roomNum to roomNumber
      }
   }
   public double Rate // changed from Char to double
   {
      get
      {
         return rate;
      }
   }
   override public string ToString() // changed overridden to override
   {
      string temp = GetType() + " Room " + RoomNumber + " Rate: " +
        Rate.ToString("C", CultureInfo.GetCultureInfo("en-US"));
      return temp; // fixed return 
   }
}
class SingleRoom : HotelRoom // fixed 
{
   public SingleRoom(int room) //: base (room) removed int room
   {
      rate += PREMIUM; // added +=
   }   
}
class Suite : HotelRoom // fixed
{
   public Suite(int room) // removed int room
   {
      rate += PREMIUM;
   }
}

