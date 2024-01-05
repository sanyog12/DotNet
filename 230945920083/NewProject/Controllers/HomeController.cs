using System.Diagnostics;
using BLL;
using BOL;
using Microsoft.AspNetCore.Mvc;
using NewProject.Models;

namespace NewProject.Controllers;

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

    public IActionResult List()
    {

        List<Employee> plist = BLLManager.GetAllData();
        ViewData["productview"] = plist;
        return View();
    }

    public IActionResult ViewTimeSHeet()
    {
        List<Employee> plist = BLLManager.GetAllData();
        ViewData["productview"] = plist;
        return View();

    }

    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int id, string date, string workdesc, int duration, string status)
    {
        BLLManager.insertAllData(id, date, workdesc, duration, status);
        return this.RedirectToAction("List");
    }




    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
