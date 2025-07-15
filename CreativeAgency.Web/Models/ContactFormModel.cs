using System.ComponentModel.DataAnnotations;

namespace CreativeAgency.Web.Models
{
    public class ContactFormModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Enquiry Type")]
        public string EnquiryType { get; set; }

        [Required]
        public string Summary { get; set; }
    }
}
