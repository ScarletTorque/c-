using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dojoval.Models;

namespace dojoval.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost("process")]
    public IActionResult Process(Survey newSurvey)
    {
        if(ModelState.IsValid)
        {
            //pass in validations
            //then redirect to success
        return RedirectToAction("Success", newSurvey);
        } else {
            //what to do if the validation error triggers
            return View("Index");
        }
        // Console.WriteLine(newSurvey.Name);
        // Console.WriteLine(newSurvey.Location);
        // Console.WriteLine(newSurvey.Language);
        // Console.WriteLine(newSurvey.Comment);
    }

    [HttpGet("Success")]
    public IActionResult Success(Survey newSurvey)
    {
        ViewBag.Survey = newSurvey;
        return View(newSurvey);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
