using System.ComponentModel.DataAnnotations;

namespace FarmFamAPI.Entities
{
    public class Crop
    {
        [Key]
        public int CropID { get; set; }

        [MaxLength(20)]
        public string CropName { get; set; }

        [MaxLength(15)]
        public string CropType { get; set; }

        public int? PredictionID { get; set; }
    
}
}
