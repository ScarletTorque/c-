using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using session.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Text;

namespace session.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //just created session variable
        // HttpContext.Session.SetString("User", "Michael");
        // //to get the data
        // string? user = HttpContext.Session.GetString("User");
        // Console.WriteLine(user);
        if (HttpContext.Session.GetInt32("Sum") == null)
        {
            HttpContext.Session.SetInt32("Sum", 0);
        }
        return View();
    }

    [HttpPost("setName")]
    public IActionResult setName(int Num)
    {
        // HttpContext.Session.SetString("User", Name);
        string src = "abcdefghijklmnopqrstuvwxyz0123456789";
        int length = 14;
        var sb = "";
        Random RNG = new Random();
        for (var i = 0; i < length; i++)
        {
            var c = src[RNG.Next(0, src.Length)];
            sb += c;
            Console.WriteLine(c);
        }
        int? original = HttpContext.Session.GetInt32("Sum");
        HttpContext.Session.SetInt32("Sum", (int)original + 1);
        HttpContext.Session.SetString("Random", sb);
        return RedirectToAction("Index");
    }

    // [HttpGet("delete")]
    // public IActionResult deleteSession()
    // {
    //     HttpContext.Session.Clear();
    //     return RedirectToAction("Index");
    // }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
