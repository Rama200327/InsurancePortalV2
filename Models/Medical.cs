using System.ComponentModel.DataAnnotations;

namespace InsuraV2.Models
{
    public class Medical : Policy
    {
        [Required]
        public string? CompanyName { get; set; }

        [Required]
        public int NumberOfEmployees { get; set; }

        [Required]
        public string? PlanType { get; set; }

        public override decimal CalculatePremium() //Poly
        {
            return NumberOfEmployees * 20;
        }
    }
}