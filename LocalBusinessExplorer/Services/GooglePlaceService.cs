using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using LocalBusinessExplorer.Models;

namespace LocalBusinessExplorer.Services
{
    public class GooglePlaceService
    {
        private readonly string _apiKey = "AIzaSyC8Ibc8cVn_47TJ-s2o6XI1-xxuys0X4kY"; 
        private readonly HttpClient _httpClient;

        public GooglePlaceService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Place>> GetNearbyRetailShops(double latitude, double longitude)
        {
            var url = $"https://maps.googleapis.com/maps/api/place/nearbysearch/json?location={latitude},{longitude}&radius=1500&type=retail&key={_apiKey}";
            var response = await _httpClient.GetStringAsync(url);

            // Parse JSON response and convert it into a list of Place objects
            var places = JsonConvert.DeserializeObject<List<Place>>(response);
            return places;
        }
    }
}
