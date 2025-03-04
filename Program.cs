using RestSharp;

namespace BusboardCSharp {
    public class Busboard {
         public static async Task Main() { 
            // var ArrivalsData = await TflClient.getStopPointArrivals();
            
            var stops = await TflClient.getNearestStops();
            // Console.WriteLine(stops.StopPoints.StopName);
            //  Console.WriteLine(stops.StopPoints.StopID);
            //  Console.WriteLine(stops.StopPoints.Distance);
                        //   Console.WriteLine(stops.StopPoints);
                          
            foreach (var Stop in stops.StopPoints) {
                Console.WriteLine($"Name: {Stop.Name}");
                Console.WriteLine($"ID: {Stop.ID}");
                Console.WriteLine($"Distance: {Stop.Distance}");
            }
            // Console.WriteLine(stops.StopPoints);


            // foreach (var Arrival in ArrivalsData) {
            //     Console.WriteLine($"lineId: {Arrival.lineId}");
            //     Console.WriteLine($"towards: {Arrival.towards}");
            //     Console.WriteLine($"timetoStation: {Arrival.timeToStation}");
            // }
        }

    }
}


