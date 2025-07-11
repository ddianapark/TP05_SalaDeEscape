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
    public IActionResult EntrarTesoro(string nombre)
    {
        int numHabitacion = 0;
        Juego NuevoJuego = new Juego("eco", numHabitacion, nombre);
        HttpContext.Session.SetString("Game", Objeto.ObjectToString(NuevoJuego));
        
        ViewBag.Nombre = nombre;
        return View("HabTesoro");
    }
    public IActionResult EntrarTesoroCerrada(string nombre)
    {
        ViewBag.Nombre = nombre;
        return View("HabTesoroCerrada");
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
        
            NuevoJuego.respuesta = "faap";

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
        NuevoJuego.respuesta = "afap";
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
        NuevoJuego.respuesta = "anubis";
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
