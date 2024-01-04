using System.ComponentModel.DataAnnotations;

namespace Model;

public class Employee{
[Required, MaxLength(80)]


    public string? Email{get;set;}    

    public String? Password{get;set;}

}