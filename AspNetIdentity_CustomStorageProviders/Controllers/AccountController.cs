using AspNetIdentity_CustomStorageProviders.Domain;
using AspNetIdentity_CustomStorageProviders.Models;
using AspNetIdentity_CustomStorageProviders.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AspNetIdentity_CustomStorageProviders.Controllers
{
  public class AccountController : Controller
  {
    private readonly UserManager<ApplicationUser> userManager;
    private readonly SignInManager<ApplicationUser> signInManager;
    private readonly IUnitOfWork unitOfWork;

    public AccountController(
      UserManager<ApplicationUser> userManager,
      SignInManager<ApplicationUser> signinManager,
      IUnitOfWork unitOfWork)
    {
      this.userManager = userManager;
      this.signInManager = signinManager;
      this.unitOfWork = unitOfWork;
    }
    public IActionResult Login()
    {
      return View();
    }

    public IActionResult SignIn()
    {
      return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignIn(SignInViewModel vm)
    {
      try
      {
        if (!ModelState.IsValid)
          return View(vm);

        var user = await userManager.FindByEmailAsync(vm.Email);

        if (user != null)
        {
          var result = await signInManager.PasswordSignInAsync(user.UserName, vm.Password, false, false);
          if (result.Succeeded)
            return RedirectToAction("Index", "Home");
        }

        return View(vm);
      }
      catch (Exception ex)
      {
        throw new NotImplementedException();
      }
    }

    public IActionResult Register()
    {
      return View();
    }

    [HttpPost]
    [AutoValidateAntiforgeryToken]
    public async Task<IActionResult> Register(RegisterViewModel vm)
    {
      try
      {
        if (!ModelState.IsValid)
        {
          return View(vm);
        }

        var result = await userManager.CreateAsync(
          new ApplicationUser
          {
            UserName = vm.UserName,
            Email = vm.Email
          },
          vm.Password
        );

        if (result.Succeeded)
        {
          unitOfWork.Commit();

          return View("SignIn", new SignInViewModel
          {
            Email = vm.Email,
          });
        }
        return View(vm);
      }
      catch
      {
        throw new NotImplementedException();
      }
    }

    [HttpPost]
    public async Task<IActionResult> Logout()
    {
      try
      {
        await signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
      }
      catch (Exception ex)
      {
        throw new NotImplementedException();
      }
    }
  }
}