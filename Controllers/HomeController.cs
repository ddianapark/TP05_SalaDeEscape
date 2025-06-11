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
    public IActionResult EntrarHabitacion1(string nombre)
    {
        int numHabitacion = 1;
        Juego Nuevojuego = new Juego("eco", numHabitacion, nombre);
        HttpContext.Session.SetString("Game", Objeto.ObjectToString(Nuevojuego));
        
        return View("HabView1");
    }

    public IActionResult EntrarHabitación2(string Respuesta)
    {
        Juego Nuevojuego;

        Nuevojuego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
        

        if (Respuesta == Nuevojuego.respuesta)
        {
            numHabitacion++;
            Nuevojuego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
            Nuevojuego.habitacion = numHabitacion;
            Nuevojuego.respuesta = "FAAP";

            HttpContext.Session.SetString("Game", Objeto.ObjectToString(Nuevojuego));
            return View("HabView2");
        }
        else
        {
            return View("HabView1");
        }

    }

    public IActionResult EntrarHabitacion3(string Respuesta)
    {


        Juego Nuevojuego;

        Nuevojuego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
        Nuevojuego.respuesta = "FAAP";
        if (Respuesta == Nuevojuego.respuesta)
        {

            NuevoJuego.habitación++;
            HttpContext.Session.SetString("Game", Objeto.ObjectToString(Nuevojuego));
            return View("HabView3");
        }
        else
        {
            return View("HabView2");
        }

    }

    public IActionResult EntrarHabitacion4(string Respuesta)
    {
        Juego Nuevojuego;
        Nuevojuego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
        Nuevojuego.respuesta = "231";
        if (Respuesta == Nuevojuego.respuesta)
        {
            NuevoJuego.habitación++;
            HttpContext.Session.SetString("Game", Objeto.ObjectToString(Nuevojuego));
            return View("HabView4");
        }
        else
        {
            return View("habView3");

        }


    }

    public IActionResult EntrarHabitacionFinal(string Respuesta)
    {
        Juego Nuevojuego;
        Nuevojuego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
        Nuevojuego.respuesta = "ANUBIS";
        if (Respuesta == Nuevojuego.respuestas)
        {   
            NuevoJuego.habitación++;
            Juego Nuevojuego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
            return View ("Resultado");
        }
        else
        {
            return View ("HabView4");

        }

    }


}
