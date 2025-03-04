using RestSharp;
using System.Text.Json.Serialization;

namespace BusboardCSharp {
public class GeoResponse {
    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("result")]
    public required GeoResult Result { get; set; }
}

public class GeoResult
{

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }
    }

}

