using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmFamAPI.Entities;
using FarmFamAPI.Repositories;

namespace FarmFamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimatePredictionController : ControllerBase
    {
        private readonly IClimatePredictionService climatePredictionService;

        public ClimatePredictionController(IClimatePredictionService climatePredictionService)
        {
            this.climatePredictionService = climatePredictionService;
        }

        [HttpGet("{state}")]
        public async Task<ActionResult<List<ClimatePrediction>>> GetClimatePredictionsByState(char state)
        {
            var climatePredictionsByState = await climatePredictionService.GetClimatePredictionsByState(state);
            if (climatePredictionsByState == null)
            {
                return NotFound();
            }
            return climatePredictionsByState;
        }
    }
}

