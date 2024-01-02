using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myAPIApp.Models;
using DAL;

namespace myAPIApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }


 public IActionResult Index()
    {return View();}

[HttpPost]
    public IActionResult Index(String Email,String Password)
    {
        int flag = DBManager.LogIn(Email,Password);
        if(flag >1){
            this.RedirectToAction("List");
        }
        else{
            this.RedirectToAction("Register");
        }

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
