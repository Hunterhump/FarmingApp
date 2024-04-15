namespace FarmFamAPI.Repositories
{
    public interface ICropService
    {
        public Task<List<CropService>> GetCropDetails(String CropName);
    }
}
