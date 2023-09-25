using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _16_ProjetoMVC.Models;

namespace _16_ProjetoMVC.Controllers;

public class ExerciciosController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Exercicio2()
    {
        return View();
    }
}
