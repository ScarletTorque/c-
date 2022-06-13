using Microsoft.AspNetCore.Mvc;
namespace YourNamespace.Controllers;     //be sure to use your own project's namespace!
public class Survey : Controller   //remember inheritance??
{
    //for each route this controller is to handle:
    [HttpGet]       //type of request
    [Route("")]     //associated route string (exclude the leading /)
    public ViewResult Index()
    {
        return View();
    }

    [HttpPost("process")]
    public IActionResult Process(string Name, string Location, string Language, string Comment)
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Location: {Location}");
        Console.WriteLine($"Language: {Language}");
        Console.WriteLine($"Comment: {Comment}");
        ViewBag.Name = Name;
        ViewBag.Location = Location;
        ViewBag.Language = Language;
        ViewBag.Comment = Comment;
        return View("result");
    }

    [HttpGet("result")]
    public ViewResult Result(string Name)
    {
        return View();
    }
}