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
    public IActionResult Create(Pet newPet)
    {
        if(!ModelState.IsValid)
        {
            return View("Index");
        }
        
        Console.WriteLine($"{newPet.Name} is a {newPet.Age} year old {newPet.Type}");
        if(newPet.Type == "tortoise")
        {
            ViewBag.SecretMessage = "You picked the secret pet type!!!!";
            return View("Secret", newPet);
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
