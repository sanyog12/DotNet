using System.Data.Common;
using System.Diagnostics;
using DAL;
using Microsoft.AspNetCore.Mvc;
using Model;
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
    

   
// [HttpPost]
//      public IActionResult Register(String Email, string Password){
        
//         return ;
//     }

      

    [HttpPost]
    public IActionResult EDITEmployee(String email, String pass)//You are updating the password here, after comparing the email and password 
    {
        return View();
    }
[HttpPost]
    public IActionResult InsertEmployee(String email, String pass){// insert into the db
        return View();
    }
    public IActionResult Register(){

        return View();
    }
  
    [HttpPost]
    public IActionResult Register(String email, String password){ // insert into db
    Console.WriteLine("11");
     Boolean flag = DBManager.Register(email,password);
      return View();
    }

    public IActionResult List1()
    {
    List<Employee> emp =DBManager.AllEmp();
   
    return View(emp);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
