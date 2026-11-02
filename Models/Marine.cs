using System.ComponentModel.DataAnnotations;

namespace InsuraV2.Models
{
    public class Marine : Policy
    {
        public int Id { get; set; }

        [Required]
        [StringLength(9)]
        public string? CompanyNationalId { get; set; }

        [Required]
        public string? ContactPersonName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [Phone]
        public string? MobileNumber { get; set; }

        [Required]
        public string? PolicyType { get; set; }

        [Required]
        public string? CargoType { get; set; }

        [Required]
        public decimal InsuredAmount { get; set; }

        [Required]
        public string? CoverageClause { get; set; }

        public decimal Price { get; set; }


        //OOP Logic -> i have applyied here a polymorphism by using overriding method.
        public override decimal CalculatePremium()
        {
            return InsuredAmount * 0.05m;
        }

    }
}