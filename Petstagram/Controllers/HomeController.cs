using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Petstagram.Models;

namespace Petstagram.Controllers;

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

    [HttpPost("addPet")]
    public IActionResult AddPet(string Name, string Type, int Age)
    {
        Console.WriteLine($"{Name} is a {Age} year old {Type}");
        if(Type == "tortoise")
        {
            ViewBag.SecretMessage = "You picked the secret pet type!!!!";
            ViewBag.Name = Name;
            return View("Secret");
        }
        return Redirect("/");
    }

    [HttpGet("privacy")]
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet("{**path}")]
    public RedirectResult Unknown()
    {
        return Redirect("/");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
