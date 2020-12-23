using System.ComponentModel.DataAnnotations;

namespace AdminLayout.Areas.Admin.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        [Required]
        public string NameAd { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        public string Img { get; set; }
        public string Status { get; set; }
    }
}