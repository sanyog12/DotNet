using System.Diagnostics;
using PMP.Models;
using PMP.BLL;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/api",()=> "This is an api");
app.MapGet("/api/catalog",()=>new {
    Id = 12, Title = "Gerbera", Description = "wedding flr", UnitPrice = 34
});

app.MapGet("/api/pmp/activities/complete", ( ) =>{

});

app.MapGet("/api/pmp/activities",()=>{
     List<Activities>  items = ProjectManager.GetAll();
    return items;
});

app.MapGet("/api/value/{id}",(int id)=>{

});

app.MapPost("/api/pmp/activities", async (Activity Activity) =>
{
    return Results.Created($"/pmp/{Activity.Id}", Activity);
});
app.MapPut("/pmp/activities/{id}",   (int id, Activity inputActivity ) =>
{
    return Results.NoContent();
});

app.Run();
