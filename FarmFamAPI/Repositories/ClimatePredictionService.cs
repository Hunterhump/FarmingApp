using FarmFamAPI.Data;
using FarmFamAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace FarmFamAPI.Repositories
{
    public class ClimatePredictionService : IClimatePredictionService
    {
        private readonly DbContextClass _dbContextClass;
        public ClimatePredictionService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<ClimatePrediction>> GetClimatePredictions()
        {
            var param = new SqlParameter("")
        }
    }
}
