using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmFamAPI.Entities;
using FarmFamAPI.Repositories;

namespace FarmFamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimatePredictionsNewController : ControllerBase
    {
        private readonly IClimatePredictionsNew climatePredictionsNew;

        public ClimatePredictionsNewController(IClimatePredictionsNew climatePredictionsNew)
        {
            this.climatePredictionsNew = climatePredictionsNew;
        }

        [HttpGet("{ClimPre}")]
        public async Task<ActionResult<List<ClimatePrediction>>> GetClimatePredictions(string ClimPre)
        {
            var climatePredictions = await climatePredictionsNew.GetClimatePredictions( ClimPre);
            if (climatePredictions == null)
            {
                return NotFound();
            }
            return climatePredictions;
        }
    }
}
