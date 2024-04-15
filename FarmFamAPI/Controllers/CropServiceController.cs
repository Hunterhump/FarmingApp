using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmFamAPI.Entities;
using FarmFamAPI.Repositories; // Assuming ICropService is defined in FarmFamAPI.Services namespace

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

        [HttpGet("{CropName}")]
        public async Task<ActionResult<List<Crop>>> GetCropDetails(string CropName) 
        {
            var cropDetails = await cropService.GetCropDetails(CropName);
            if (cropDetails == null)
            {
                return NotFound();
            }
            return cropDetails;
        }
    }
}