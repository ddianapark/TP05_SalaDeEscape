namespace TP05_SalaDeEscape.Models;
using Newtonsoft.Json;

public class Juego
{
    [JsonProperty]
    public int habitacion;
    [JsonProperty]
    public string respuesta;

    public Juego(string respuesta, int habitacion)
    {
        
        this.respuesta = respuesta;
        this.habitacion = habitacion;
    }


}

