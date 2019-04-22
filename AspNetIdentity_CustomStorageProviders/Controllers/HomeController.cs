using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetIdentity_CustomStorageProviders.Models;
using AspNetIdentity_CustomStorageProviders.Domain;

namespace AspNetIdentity_CustomStorageProviders.Controllers
{
  public class HomeController : Controller
  {
    private readonly IUnitOfWork unitOfWork;

    public HomeController(IUnitOfWork unitOfWork)
    {
      this.unitOfWork = unitOfWork;
    }
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
