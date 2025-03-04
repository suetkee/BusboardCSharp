using RestSharp;

namespace BusboardCSharp {
    public static class GeoClient {
        private static readonly RestClient GeolocationClient = new RestClient("https://api.postcodes.io/postcodes/");

        public static async Task<BusboardCSharp.GeoResponse> GetGeolocation(){
            var request = new RestRequest($"{UserPostCode.GetUserPostCode()}");
            var response = await GeolocationClient.GetAsync<BusboardCSharp.GeoResponse>(request);

            if (response == null) {
                throw new Exception("Geolocation API error");
            }
            return response;
        } 




    }


}