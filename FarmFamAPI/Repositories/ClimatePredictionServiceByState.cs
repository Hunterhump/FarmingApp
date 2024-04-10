using FarmFamAPI.Data;
using FarmFamAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace FarmFamAPI.Repositories
{
    public class ClimatePredictionServiceByState : IClimatePredictionService
    {
        private readonly DbContextClass _dbContextClass;
        public ClimatePredictionServiceByState(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }
        public async Task<List<ClimatePrediction>> GetClimatePredictionsByState(string State)
        {
            var param = new SqlParameter("@State", State);
            var ClimatePredictionByState = await Task.Run(() => _dbContextClass.ClimatePredictions.FromSqlRaw("exec GetClimatePredictionsByState @State", param).ToListAsync());
            return ClimatePredictionByState;


            }
    }
}

