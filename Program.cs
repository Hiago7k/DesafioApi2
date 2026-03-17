using (HttpClient httpClient = new HttpClient()) 
{
    try {
        string resposta = await httpClient.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        Console.WriteLine(resposta);
    } catch (Exception ex) 
    {
        Console.WriteLine($"Erro na busca da api {ex:Message}");
    }
}