using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmFamAPI.Entities;
using FarmFamAPI.Repositories;

namespace FarmFamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmingPlanByCompController : ControllerBase // Changed from "Controller" to "ControllerBase"
    {
        private readonly IFarmingPlanByCompatibility farmingPlanByCompatibility;

        public FarmingPlanByCompController(IFarmingPlanByCompatibility farmingPlanByCompatibility)
        {
            this.farmingPlanByCompatibility = farmingPlanByCompatibility;
        }

        [HttpGet("{CompData}")] // Removed unnecessary parentheses from "{CompData}"
        public async Task<ActionResult<List<FarmingPlan>>> GetFarmingPlanByCompatibility(string CompData) // Added "ActionResult" to the return type
        {
            var farmingPlans = await farmingPlanByCompatibility.GetFarmingPlanByCompatibility(CompData);
            if (farmingPlans == null)
            {
                return NotFound();
            }
            return farmingPlans;
        }
    }
}

