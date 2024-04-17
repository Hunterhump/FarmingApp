using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmFamAPI.Entities;
using FarmFamAPI.Repositories;

namespace FarmFamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CropCompatibilityController : ControllerBase
    {
        private readonly ICropCompatibilityService cropCompatibilityService;

        public CropCompatibilityController(ICropCompatibilityService cropCompatibilityService)
        {
            this.cropCompatibilityService = cropCompatibilityService;
        }

        [HttpGet("{CropComp}")]
        public async Task<ActionResult<List<CropCompatibility>>> GetCropCompatibility(string CropComp)
        {
            var cropCompatibility = await cropCompatibilityService.GetCropCompatibility(CropComp);
            if (cropCompatibility == null)
            {
                return NotFound();
            }
            return Ok(cropCompatibility);
        }
    }
}