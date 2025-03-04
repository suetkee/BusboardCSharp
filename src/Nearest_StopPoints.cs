using System.Dynamic;

namespace BusboardCSharp {
        public class Nearest_StopPoints {
        public required string[] Modes { get; set; }
        public required string Name { get; set; }
        public decimal Distance { get; set; }    
        public required StopPointArrival[] Arrivals { get; set; }

        public string Message {get; set;}

        public Nearest_StopPoints(string message = ""){
        Message = message;
        }

    }

}
