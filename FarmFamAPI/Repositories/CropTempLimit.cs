using FarmFamAPI.Data;
using FarmFamAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarmFamAPI.Repositories
{
    public class CropTempLimit : ICropTempLimit
    {
        private readonly DbContextClass _dbContextClass;

        public CropTempLimit(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<Crop>> GetCropTempLimit(string CropName)
        {
            var param = new SqlParameter("@CropName", CropName);
            var cropTempLimits = await _dbContextClass.Crop.FromSqlRaw("exec GetCropTempLimit @CropName", param).ToListAsync();
            return cropTempLimits;
        }
    }
}

