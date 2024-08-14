using System;
using System.Text.Json;
using SamplePrismApp.Models;

namespace SamplePrismApp.ViewModel
{
	public class ApiService
	{
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Items>> GetItemsAsync()
        {
            var url = "https://dummyapi.online/api/products"; // Replace with your API URL
            var response = await _httpClient.GetStringAsync(url);
            return JsonSerializer.Deserialize<List<Items>>(response);
        }
    }
}

