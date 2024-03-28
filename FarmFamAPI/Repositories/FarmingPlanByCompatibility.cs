

using FarmFamAPI.Data;
using FarmFamAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FarmFamAPI.Repositories
{
    public class FarmingPlanByCompatibility : IFarmingPlanByCompatibility
    {
        private readonly DbContextClass _dbContextClass;

        public FarmingPlanByCompatibility(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;
        }

        public async Task<List<FarmingPlan>> GetFarmingPlanByCompatibility(string CompData)
        {
            var param = new SqlParameter("@CompData", CompData);
            var farmingPlanByCompatibility = await _dbContextClass.FarmingPlan.FromSqlRaw("exec GetFarmingPlanByCompatibilty @CompData", param).ToListAsync();
            return farmingPlanByCompatibility;
        }
    }
}


