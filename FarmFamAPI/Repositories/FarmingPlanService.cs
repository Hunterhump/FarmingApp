using FarmFamAPI.Data;
using FarmFamAPI.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace FarmFamAPI.Repositories
{
    public class FarmingPlanService : IFarmingPlanService
    {
        private readonly DbContextClass _dbContextClass;

        public FarmingPlanService(DbContextClass dbContextClass)
        {
            _dbContextClass = dbContextClass;

        }
    }
}

