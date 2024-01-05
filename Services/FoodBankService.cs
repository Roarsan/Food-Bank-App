// FoodBankService.cs

using CW1_MVC_Food_Bank_Website.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CW1_MVC_Food_Bank_Website.Services
{
    public class FoodBankService
    {
        private readonly HttpClient _httpClient;

        public FoodBankService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<List<FoodBank>> GetFoodBanksAsync()
        {
            var response = await _httpClient.GetStringAsync("https://www.givefood.org.uk/api/2/foodbank/sid-valley/");
            return JsonConvert.DeserializeObject<List<FoodBank>>(response);
        }
    }
}
