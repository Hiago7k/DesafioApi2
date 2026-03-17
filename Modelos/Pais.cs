using System.Text.Json.Serialization;

namespace DesafioApi2.Modelos;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }

    [JsonPropertyName("capital")]
    public string? Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }
    [JsonPropertyName("continente")]
    public string? Continente { get; set; }
    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }


    public void ExibirDetalhes() 
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("CEP System");

        Console.WriteLine($"\nPais: {Nome}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"Populacao: {Populacao}");
        Console.WriteLine($"Continente: {Continente}");
        Console.WriteLine($"Idioma: {Idioma}");


    }
}
