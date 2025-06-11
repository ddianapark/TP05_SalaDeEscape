namespace TP05_SalaDeEscape.Models;
using Newtonsoft.Json;

public class Juego
{
    [JsonProperty]
    public int habitacion;
    [JsonProperty]
    public string respuesta;
    [JsonProperty]
    public string nombre;

    public Juego(string respuesta, int habitacion, string nombre)
    {
        
        this.respuesta = respuesta;
        this.habitacion = habitacion;
        this.nombre = nombre;
    }


}

