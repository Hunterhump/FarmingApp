using System.ComponentModel.DataAnnotations;

namespace FarmFamAPI.Entities
{
    public class FarmingPlan
    {
        public int PlanID { get; set; }

        public int? CompID { get; set; }

        [MaxLength(10)]
        public string CompData { get; set; }
    }
}

