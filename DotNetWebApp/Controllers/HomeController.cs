using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using d3mvc.Models;
using catalog;

namespace d3mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Portfolio(){
        return View();
    }



    public IActionResult Animation(){
        Product p1 = new Product();
        p1.Title = "Toji";
        p1.Description = "Fanned by many";
        p1.Unitprice = 10000;
        p1.Quantity = 100000;
        p1.Imageurl = "images/Tojii.jpeg";
        ViewData["Animation"]=p1;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
