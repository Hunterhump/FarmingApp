using FarmFamAPI.Data;
using FarmFamAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace FarmFamAPI.Repositories
{
    public class CropService : ICropService
    {
        private readonly DbContextClass _dbContextClass;
        public CropService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<Crop>> GetCropDetails(String CropName)
        {
            var param = new SqlParameter("@CropName", CropName);
            var cropService = await Task.Run(() => _dbContextClass.Crop.FromSqlRaw("exec CropService @CropName", param).ToListAsync());
            return cropService;
        }
    }
}
