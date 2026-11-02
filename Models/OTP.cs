using System.ComponentModel.DataAnnotations;

namespace InsuraV2.Models
{
    public class OTP
    {
        public string Email { get; set; }

        [Required]
        public string OtpCode { get; set; }
    }
}