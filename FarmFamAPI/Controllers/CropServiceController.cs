using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmFamAPI.Entities;
using FarmFamAPI.Repositories;

namespace FarmFamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CropServiceController : ControllerBase
    {
        private readonly ICropService cropService;

        public CropServiceController(ICropService cropService)
        {
            this.cropService = cropService;
        }

        [HttpGet]
        public async Task<ActionResult<List<CropService>>> GetCropDetails()
        {
            var cropDetails = await cropService.GetCropDetails();
            if (cropDetails == null)
            {
                return NotFound();
            }
            return cropDetails;
        }
    }
}