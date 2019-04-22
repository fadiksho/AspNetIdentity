using AspNetIdentity_CustomStorageProviders.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AspNetIdentity_CustomStorageProviders.Controllers
{
  [Authorize]
  public class UserController : Controller
  {
    private readonly UserManager<ApplicationUser> userManager;

    public UserController(
      UserManager<ApplicationUser> userManager)
    {
      this.userManager = userManager;
    }

    public async Task<IActionResult> Profile()
    {
      try
      {
        var user = await userManager.GetUserAsync(User);
        return View(user);
      }
      catch (Exception ex)
      {
        throw new NotImplementedException();
      }
    }
  }
}
