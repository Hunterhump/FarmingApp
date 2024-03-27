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
        public async Task<List<CropCompatibilityService>> GetCropCompatibility()
        {
            return await GetCropCompatibility();

        }

    }

}