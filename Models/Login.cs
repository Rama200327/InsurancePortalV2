using System.ComponentModel.DataAnnotations;

namespace InsuraV2.Models
{

    //ViewModel instead of using only Model -> cause the model include one field or property ; it's Saves space of memory .
    public class Login
    {
        //Validation
        [Required] //don't accept empty field
        [EmailAddress] //check if text input is include "xxx@gmail.com" 
        public string Email { get; set; } 

    }
}