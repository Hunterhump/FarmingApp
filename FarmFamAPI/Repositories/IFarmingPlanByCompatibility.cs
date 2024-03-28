using FarmFamAPI.Entities;

namespace FarmFamAPI.Repositories
{
    public interface IFarmingPlanByCompatibility
    {
        public Task<List<FarmingPlan>> GetFarmingPlanByCompatibility(string CompData);

    }
}
