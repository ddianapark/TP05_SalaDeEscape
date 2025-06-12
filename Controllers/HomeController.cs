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
        Juego NuevoJuego = new Juego("eco", numHabitacion, nombre);
        HttpContext.Session.SetString("Game", Objeto.ObjectToString(NuevoJuego));
        
        return View("HabView1");
    }

    public IActionResult EntrarHabitacion2(string Respuesta)
    {
        Juego NuevoJuego;

        NuevoJuego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
        

        if (Respuesta == NuevoJuego.respuesta)
        {
            NuevoJuego.habitacion++;
            NuevoJuego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
        
            NuevoJuego.respuesta = "FAAP";

            HttpContext.Session.SetString("Game", Objeto.ObjectToString(NuevoJuego));
            return View("HabView2");
        }
        else
        {
            return View("HabView1");
        }

    }

    public IActionResult EntrarHabitacion3(string Respuesta)
    {
        Juego NuevoJuego;

        NuevoJuego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
        NuevoJuego.respuesta = "FAAP";
        if (Respuesta == NuevoJuego.respuesta)
        {

            NuevoJuego.habitacion++;
            HttpContext.Session.SetString("Game", Objeto.ObjectToString(NuevoJuego));
            return View("HabView3");
        }
        else
        {
            return View("HabView2");
        }

    }

    public IActionResult EntrarHabitacion4(string Respuesta)
    {
        Juego NuevoJuego;
        NuevoJuego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
        NuevoJuego.respuesta = "231";
        if (Respuesta == NuevoJuego.respuesta)
        {
            NuevoJuego.habitacion++;
            HttpContext.Session.SetString("Game", Objeto.ObjectToString(NuevoJuego));
            return View("HabView4");
        }
        else
        {
            return View("habView3");

        }


    }

    public IActionResult EntrarHabitacionFinal(string Respuesta)
    {
        Juego NuevoJuego;
        NuevoJuego = Objeto.StringToObject<Juego>(HttpContext.Session.GetString("Game"));
        NuevoJuego.respuesta = "ANUBIS";
        if (Respuesta == NuevoJuego.respuesta)
        {   
            ViewBag.nombre = NuevoJuego.nombre;
            NuevoJuego.habitacion++;
            HttpContext.Session.SetString("Game", Objeto.ObjectToString(NuevoJuego));
            return View ("Resultado");
        }
        else
        {
            return View ("HabView4");

        }

    }


}
