namespace BusboardCSharp {
    public class StopPointArrival {
        public required string lineId { get; set; }
        public required string lineName { get; set; }
        public required decimal timeToStation { get; set; }
        public required string towards { get; set; }
  
    }
}
