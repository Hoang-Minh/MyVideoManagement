using System.ComponentModel.DataAnnotations;

namespace MyVideoMangement.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}