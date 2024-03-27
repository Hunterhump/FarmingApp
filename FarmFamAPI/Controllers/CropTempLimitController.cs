using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FarmFamAPI.Entities;
using FarmFamAPI.Repositories;

namespace FarmFamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CropTempLimitController : ControllerBase
    {
        private readonly ICropTempLimit cropTempLimit;

        public CropTempLimitController(ICropTempLimit cropTempLimit)
        {
            this.cropTempLimit = cropTempLimit;
        }

        [HttpGet("{CropName}")]
        public async Task<ActionResult<List<CropTempLimit>>> GetCropTempLimit(string CropName)
        {
            var CropTempLimit = await cropTempLimit.GetCropTempLimit(CropName);
            if (CropTempLimit == null)
            {
                return NotFound();
            }
            return CropTempLimit;
        }
    }
}
