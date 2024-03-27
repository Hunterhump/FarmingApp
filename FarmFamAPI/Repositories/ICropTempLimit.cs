using FarmFamAPI.Entities;

namespace FarmFamAPI.Repositories
{
    public interface ICropTempLimit
    {
        public Task<List<Crop>> GetCropTempLimit(string CropName);
    }
}
