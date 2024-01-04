using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PracticeApp.Models;
using BLL;
using BOL;

namespace PracticeApp.Controllers;

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


    public IActionResult List()
    {

        BLLManager mgr = new BLLManager();
        List<Student> list = mgr.GetList();

        ViewData["allStudents"] = list;
        return View();
    }




    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Insert()
    {
        return View();
    }
      public IActionResult Delete()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Delete(int id)
    {
        BLLManager mgr = new BLLManager();
        bool status = mgr.DeleteById(id);
        return this.RedirectToAction("List");
    }

    [HttpPost]
    public IActionResult Insert(int id, string name, string email)
    {
        BLLManager mgr = new BLLManager();
        bool status = mgr.InsertInto1(id, name, email);
        return this.RedirectToAction("List");
    }

    public IActionResult Update(){
        return View();
    }

[HttpPost]
    public IActionResult Update(int id , String name){
        BLLManager mgr = new BLLManager();
        mgr.UpdateById(id,name);
        return this.RedirectToAction("List");
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
