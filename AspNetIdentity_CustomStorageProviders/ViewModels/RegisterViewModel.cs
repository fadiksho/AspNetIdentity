using System.ComponentModel.DataAnnotations;

namespace AspNetIdentity_CustomStorageProviders.ViewModels
{
  public class RegisterViewModel
  {
    [Required]
    [Display(Name = "Username")]
    [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Username can only contain letters or digits.")]
    [StringLength(maximumLength: 15, MinimumLength = 3)]
    public string UserName { get; set; }
    [Required]
    [Display(Name = "E-Mail")]
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [StringLength(80, MinimumLength = 8, ErrorMessage = "Password must be 8 long and maximum 80 long.")]
    public string Password { get; set; }
    [Required]
    [Display(Name = "Confirm Password")]
    [DataType(DataType.Password)]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
  }
}
