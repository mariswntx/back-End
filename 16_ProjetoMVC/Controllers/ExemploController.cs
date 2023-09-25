using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _16_ProjetoMVC.Models;

namespace _16_ProjetoMVC.Controllers;

public class ExemploController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

 public IActionResult Exemplo2()
    {
        return View();
    }
}
