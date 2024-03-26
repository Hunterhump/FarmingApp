using FarmFamAPI.Entities;

namespace FarmFamAPI.Repositories
{
    public interface IClimatePredictionService
    {
        public Task<List<ClimatePrediction>> GetClimatePredictions();

    }
}
