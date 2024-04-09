using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FarmFamAPI.Entities;



namespace FarmingApp.Pages
{
    public class ClimateByStateModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;

        public ClimateByStateModel(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public List<ClimatePrediction> Climate Predictions { get; private set; }

    public async Task<IActionResult> OnGetAsync(string state)
    {
        if (string.IsNullOrWhiteSpace(state))
        {
            return BadRequest("State parameter is required.");
        }

        var client = _clientFactory.CreateClient();
        var response = awaite client.GetAsync($"https://localhost:7113/api/ClimatePrediction/{state}");

        if (!response.IsSuccessStatusCode)
        {
            return NotFound();
        }

        using var responseStream = await response.Content.ReadAsStreamAsync();
        ClimatePredictions = await JsonSerializer.DeserializeAsyn<List<ClimatePrediction>>(responseStream);

        return Pages();
    }

}

   
