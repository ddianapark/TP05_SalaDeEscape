using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP05_SalaDeEscape.Models;
using Newtonsoft.Json;

namespace TP05_SalaDeEscape.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult EntrarHabitación2 (string Respuesta)
    {
        int numHabitacion = 1;
        Juego juego = new Juego ("eco", numHabitacion);
        HttpContext.Session.SetString("Game", Objeto.ObjectToString(juego));

        if (Respuesta == juego.respuesta)
        {
            numHabitacion++;
            juego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
            juego.habitacion = numHabitacion;
            juego.respuesta = "FAAP";

            HttpContext.Session.SetString("Game", Objeto.ObjectToString(juego));
            return View("HabView2");
        }
        else
        {
            return View("HabView1");
        }

    }

    public IActionResult EntrarHabitacion3(string Respuesta)
    {
        Juego juego;
        if(Respuesta == ResCorrecto)
      {
        juego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));


      }

    }


}
