using RestSharp;

namespace BusboardCSharp {
    public static class TflClient {
        private static readonly RestClient StopPointClient = new RestClient("https://api.tfl.gov.uk/StopPoint");

        public static async Task<BusboardCSharp.StopPointArrival[]> getStopPointArrivals(){
            var request = new RestRequest($"{StopPointID.GetUserStopPointId()}/Arrivals");
            var response = await StopPointClient.GetAsync<BusboardCSharp.StopPointArrival[]>(request);

            if (response == null) {
                throw new Exception("Tfl API error");
            }
            return response;
        } 

        public static async Task<BusboardCSharp.StopPointData> getNearestStops(){
            var GeoLocationData = await GeoClient.GetGeolocation();
            var request = new RestRequest($"/?lat={GeoLocationData.Result.Latitude}&lon={GeoLocationData.Result.Longitude}&stopTypes=NaptanPublicBusCoachTram");
            var response = await StopPointClient.GetAsync<BusboardCSharp.StopPointData>(request);

            if (response == null) {
                throw new Exception("Tfl API error");
            }
            return response;
        } 


    }


}

