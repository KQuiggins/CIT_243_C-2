using static System.Console;
class Flights
{
    static void Main()
    {
        // Write your main here
    }

    public static string GetFlightInfo(int flight, int[] flightNumbers, string[] codes, string[] names, string[] times)
    {
    }
    public static string GetFlightInfo(string code, int[] flightNumbers, string[] codes, string[] names, string[] times)
    {
    }

}

/*Flights Number  Airport Code  Airport Name         Time
201              AUS          Austin               0710

321              CRP          Corpus Christi       0830

510              DFW          Dallas Fort Worth    0915

633              HOU          Houston              1140*/

/*Pass the user's entry to one of two overloaded methods,
and then display a returned string with all the flight details.*/

/*for example, if 201 was input,
the output would be: Flight #201 AUS Austin Scheduled at: 0710*/