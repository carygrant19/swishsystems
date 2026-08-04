using System.ComponentModel.DataAnnotations;

namespace SwishSystems.Web.Models
{
    public class ContactFormModel
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")] 
        public string Email { get; set; } = "";

        [Required(ErrorMessage = "Please select an interest.")]
        public string Interest { get; set; } = "";

        [Required(ErrorMessage = "Please provide some project details.")]
        public string Message { get; set; } = "";
    }
}
