using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using myAPIApp.Models;

namespace myAPIApp.Controllers;

public class DeleteEmployeeController : Controller
{
    private readonly ILogger<DeleteEmployeeController> _logger;

    public DeleteEmployeeController(ILogger<DeleteEmployeeController> logger)
    {
        _logger = logger;
    }


[HttpGet]
  public IActionResult DeleteEmployee()
    {
        return View();
    }

[HttpPost]
 public IActionResult DeleteEmployee(String s1, string s2)//compare id and password both to delete the employee
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
