using FarmFamAPI.Entities;

namespace FarmFamAPI.Repositories
{
    public interface IClimatePredictionsNew

    {
        public Task<List<ClimatePrediction>> GetClimatePredictions(String ClimPre);
    }
}
