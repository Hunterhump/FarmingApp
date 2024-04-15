using FarmFamAPI.Entities;

namespace FarmFamAPI.Repositories
{
    public interface ICropService
    {
        public Task<List<Crop>> GetCropDetails(String CropName);
    }
}
