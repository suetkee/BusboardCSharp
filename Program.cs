using RestSharp;

namespace BusboardCSharp {
    public class Busboard {
         public static async Task Main() { 

           var Arrivals = await TflClient.getArrivalsfromPostCode();
           foreach(var Arrival in Arrivals){
                Console.WriteLine();
                Console.WriteLine($"Stop Name: {Arrival.Name}");
                Console.WriteLine($"Distance from Postcode: {Math.Round(Arrival.Distance,1)} m");
                foreach(var Mode in Arrival.Modes){
                    Console.WriteLine($"Transpost modes available: {Mode}");
                }
                Console.WriteLine();
                foreach(var arrivaltime in Arrival.Arrivals){
                    Console.WriteLine($"Line Name: {arrivaltime.lineName}");
                    Console.WriteLine($"{Math.Round(arrivaltime.timeToStation/60,1)} minutes");
                    Console.WriteLine($"Heading towards: {arrivaltime.towards}");
                    Console.WriteLine();
                }
                Console.WriteLine();
           }
        }

    }
}

