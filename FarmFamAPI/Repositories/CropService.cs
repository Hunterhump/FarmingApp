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
      
    }
}
