using InsuraV2.Models;
using System.ComponentModel.DataAnnotations;

public class Policy
{
    [Key]
    public int PolicyId { get; set; }

    [Required]
    public string PolicyNumber { get; set; }

    [Required]
    public string PolicyHolderName { get; set; }

    public decimal Premium { get; set; }


    //virtual ; it's a method of the Parent Class !
    public virtual decimal CalculatePremium()
    {
        return Premium;
    }

}