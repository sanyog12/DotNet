using System.ComponentModel.DataAnnotations;

namespace Model;

public class Employee{
[Required, MaxLength(80)]
    public int? Id{get;set;}

    public String? EmpName{get;set;}

    public String? Desg{get;set;}

}