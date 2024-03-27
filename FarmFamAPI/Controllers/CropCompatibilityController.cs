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

        [HttpGet]
        public async Task<ActionResult<List<CropCompatibility>>> GetCropCompatibility()
        {
            var cropCompatibility = await cropCompatibilityService.GetCropCompatibility();
            if (cropCompatibility == null)
            {
                return NotFound();
            }
            return cropCompatibility;
        }
    }
}