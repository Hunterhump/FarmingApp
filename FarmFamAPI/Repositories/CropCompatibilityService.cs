using FarmFamAPI.Data;
using FarmFamAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace FarmFamAPI.Repositories
{
    public class CropCompatibilityService : ICropCompatibilityService
    {
        private readonly DbContextClass _dbContextClass;

        public CropCompatibilityService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<CropCompatibilityService>> GetCropCompatibility(string CropComp) 
        {
            var param = new SqlParameter("@CropComp", CropComp);
            var cropComp = await Task.Run(() => _dbContextClass.CropCompatibility.FromSqlRaw("exec CropCompatibility @CropComp", param).ToListAsync());
            return cropComp;
        }

    }

}