using System.ComponentModel.DataAnnotations;

namespace StoHealthRecord.Models
{
    public class TB
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PatientId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public DateTime DiagnosisDate { get; set; }

        [Required]
        public string TBStatus { get; set; }

        [Required]
        public DateTime TreatmentStartDate { get; set; }

        [Required]
        public string RetentionStatus { get; set; }

        public string NegativeOutcome { get; set; }

        [Required]
        public string TPTStatus { get; set; }

        public int? ViralLoad { get; set; }

        public string BloodPressure { get; set; }

        public int? HeightCm { get; set; }

        public int? WeightKg { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
