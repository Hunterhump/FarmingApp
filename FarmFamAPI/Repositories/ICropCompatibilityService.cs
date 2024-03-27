using FarmFamAPI.Entities;

namespace FarmFamAPI.Repositories
{
    public interface ICropCompatibilityService
    {
        public Task<List<CropCompatibilityService>> GetCropCompatibility();
    }
}
