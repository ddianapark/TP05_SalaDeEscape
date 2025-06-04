namespace TP05_SalaDeEscape.Models;
using Newtonsoft.Json;

public class Hab1
{
    [JsonProperty]
    public string respuesta;
    [JsonProperty]
    public const string codigo = "eco";

    public Hab1(string respuesta)
    {
        this.respuesta = respuesta;
    }


}

