using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FarmFamAPI.Entities;



namespace FarmingApp.Pages.ClimateByState
{
    public class ClimateByStateModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;

        public ClimateByStateModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        //   public List<ClimatePrediction> Climate Predictions { get; private set; };

        public async Task OnGetAsync(string stateAbbreviation)
        {
            if (string.IsNullOrWhiteSpace(stateAbbreviation))
            {
                //return BadRequest("State parameter is required.");
            }

            string baseUrl = "http://localhost:7113";
            string route = "/api/ClimatePrediction/";

            string apiUrl = $"{baseUrl}{route}{stateAbbrevaiation}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    //return NotFound();
                }
            }
            //return Pages();
        }

    }
}
