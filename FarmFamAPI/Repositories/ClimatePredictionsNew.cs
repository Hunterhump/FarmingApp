using FarmFamAPI.Data;
using FarmFamAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FarmFamAPI.Repositories
{
    public class ClimatePredictionsNew : IClimatePredictionsNew

    {
        private readonly DbContextClass _dbContextClass;
        public ClimatePredictionsNew(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<ClimatePrediction>> GetClimatePredictions()
        {
            return await GetClimatePredictions();

        }
        
    }

}
