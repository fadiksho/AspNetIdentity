using System.ComponentModel.DataAnnotations;

namespace AspNetIdentity_CustomStorageProviders.ViewModels
{
  public class SignInViewModel
  {
    [Required]
    [Display(Name = "E-Mail")]
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [StringLength(80, MinimumLength = 8, ErrorMessage = "Password must be 8 long and maximum 80 long.")]
    public string Password { get; set; }
  }
}
