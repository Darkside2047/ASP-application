using System.ComponentModel.DataAnnotations;

namespace WilliamBowensTutorialApp.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "A valid email address is required")]
        [EmailAddress(ErrorMessage = "Email must include the @ symbol")]

        public string? Email { get; set; }


        [Required(ErrorMessage = "A valid telephone number is required.")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "The number must be 10 digits.")]
        public string? Number { get; set; }

    }
}
