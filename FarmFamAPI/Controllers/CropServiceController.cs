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
        public async Task<List<CropService>> GetCropDetails(String CropName)
        {
            var cropService = await cropService.GetCropDetails(CropName);
            if (cropService == null)
            {
                return NotFound();
            }
            return cropService;
        }
    }
}