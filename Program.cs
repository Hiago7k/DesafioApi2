using DesafioApi2.Modelos;
using System.Text.Json;

using (HttpClient httpClient = new HttpClient()) 
{
    try {
        string resposta = await httpClient.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta)!;

    } catch (Exception ex) 
    {
        Console.WriteLine($"Erro na busca da api {ex:Message}");
    }
}