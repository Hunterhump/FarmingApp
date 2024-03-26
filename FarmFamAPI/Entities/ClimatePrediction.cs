using System.ComponentModel.DataAnnotations;


namespace FarmFamAPI.Entities
{
    public class ClimatePrediction
    {
        public int ClimatePredictiom { get; set; }
        public int PredictionID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? Temperature { get; set; } // Nullable int
        public string Rainfall { get; set; }
        public DateTime? Date { get; set; } // Nullable DateTime
    }
}

