namespace InsuraV2.Models
{
    public class MotorPolicies 
   {
        public int Id { get; set; }

        public string PlateNumber { get; set; }

        public string ChassisNumber { get; set; }

        public string? VehicleType { get; set; }

        public string FullName { get; set; }

        public string NationalId { get; set; }

        public string Status { get; set; } = "Active";

        public decimal Premium { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
