using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myAPIApp.Models;

namespace myAPIApp.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    // public IActionResult EDITEmployee(){
    //     return View();
    // }

    public IActionResult EDITEmployee()
    {
        return View();
    }

    public IActionResult InsertEmployee(){
        return View();
    }

     public IActionResult List(){
        return View();
    }

     public IActionResult Register(){
        return View();
    }
    [HttpPost]
    public IActionResult EDITEmployee(String email, String pass)//You are updating the password here, after comparing the email and password 
    {
        return View();
    }
[HttpPost]
    public IActionResult InsertEmployee(String email, String pass){// insert into the db
        return View();
    }
[HttpPost]
     public IActionResult List(String email, String pass){ //Select everything from db 
        return View();
    }
[HttpPost]
     public IActionResult Register(String email, String pass){ // insert into db
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
