using System.ComponentModel.DataAnnotations;

namespace InsuraV2.Models
{
    public class Travel : Policy
    {
        [Key] //PK = TravelPlanId
        public int TravelPlanId { get; set; }

        public string PlanType { get; set; }

        public int Period { get; set; }

        public int NumberOfMembers { get; set; }

        public override decimal CalculatePremium()
        {
            return 200;
        }
    }
}