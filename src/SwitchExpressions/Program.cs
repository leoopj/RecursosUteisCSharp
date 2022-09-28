// See https://aka.ms/new-console-template for more information

// Exemplo 1
var fonteDados = FonteDados.DB;
var dados = fonteDados switch
{
	FonteDados.API => BuscaDadosAPI(),
	FonteDados.DB => BuscaDadosDB(),
	_ => "Retorno padrão"
};

string BuscaDadosAPI() => "Dados API";
string BuscaDadosDB() => "Dados DB";

Console.WriteLine(dados);

// Exemplo 2

Console.WriteLine();
Console.WriteLine("---------------------------------------------------");
Console.WriteLine();

Console.WriteLine($"Temperatura: -5ºC => {AvaliarCondicao(-5)}");
Console.WriteLine($"Temperatura: 13ºC => {AvaliarCondicao(13)}");
Console.WriteLine($"Temperatura: 22ºC => {AvaliarCondicao(22)}");
Console.WriteLine($"Temperatura: 29ºC => {AvaliarCondicao(29)}");
Console.WriteLine($"Temperatura: 40ºC => {AvaliarCondicao(40)}");
Console.WriteLine($"Temperatura: 100ºC => {AvaliarCondicao(100)}");

static string AvaliarCondicao(double temperatura) =>
    temperatura switch
    {
        < 0 => "Muito frio",
        > 0 and <= 17 => "Frio",
        > 18 and <= 26 => "Ameno",
        > 26 and <= 30 => "Calor",
        > 30 and <= 50 => "Muito Calor",
        _ => "Sem classificação"
    };