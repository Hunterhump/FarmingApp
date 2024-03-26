using FarmFamAPI.Entities;
using FarmFamAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FarmFamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimatePredictionController : Controller
    {
        private readonly IClimatePredictionService climatePredictionService;
        public ClimatePredictionController(IClimatePredictionService climatePredictionService)
        {
            this.climatePredictionService = climatePredictionService;
        }
        
    }
    [HttpGet("{State}")]

    public async Task<List<ClimatePrediction>> GetClimatePredictionsByState(char State);
    {
    var ClimatePredictionByState = await climatePredictionService.GetClimatePredictionsByState(State);
    if (ClimatePredictionByState == null) 
        {
        return NotFound();
}
return ClimatePredictionByState;
}
}

