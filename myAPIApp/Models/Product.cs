using System.ComponentModel.DataAnnotations;

namespace Model;

public class Product{
    [Required,MaxLength(80)]
    public int? Id{get;set;}
    public String? ProdName{get;set;}

    public String? Desc{get;set;}
}