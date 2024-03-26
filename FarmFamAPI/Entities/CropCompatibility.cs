using System.ComponentModel.DataAnnotations;

namespace FarmFamAPI.Entities
{
    public class CropCompatibility
    {
        public int CompID { get; set; }
        public int? CropID1 { get; set; }
        public int? CropID2 { get; set; }
    }
}
