using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace BusboardCSharp {
    public class StopPointData {

        [JsonPropertyName("stopPoints")]
        public required StopPoint[] StopPoints { get; set; }
    }

    public class StopPoint {
        [JsonPropertyName("modes")]
        public string[]? Modes { get; set; }

        [JsonPropertyName("id")]
        public string? ID { get; set; }

        [JsonPropertyName("commonName")]
        public string? Name { get; set; }

        [JsonPropertyName("distance")]
        public decimal Distance { get; set; }

    }
}
