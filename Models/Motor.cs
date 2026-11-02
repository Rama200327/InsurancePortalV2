using System.ComponentModel.DataAnnotations;


namespace InsuraV2.Models
{
    public class Motor
    {
        public int Id { get; set; }

        // Vehicle
        public string PlateNumber { get; set; }
        [Required]
        public string ChassisNumber { get; set; }
        [Required]
        public string VehicleType { get; set; }

        // Customer
        [Required]
        public string FullName { get; set; }

        [Required]
        public string NationalId { get; set; }

        // Coverage
        [Required]
        public bool AgencyRepair { get; set; }
        public bool NaturalHazards { get; set; }

        // Payment2
        [Required]
        public string PaymentPlan { get; set; }

        // Pricing
        [Required]
        public decimal Premium { get; set; }
        [Required]
        public string RegistrationNumber { get; set; }
        [Required]
        public string VehicleModel { get; set; }
        [Required]
        public int ProductionYear { get; set; }
        [Required]
        public string CarType { get; set; }
        [Required]
        public bool IsDriver { get; set; }
        [Required]
        public decimal VehicleValue { get; set; }
    }
}