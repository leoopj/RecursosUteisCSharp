

// Record: É utilizado ao invez de classes para criação de conjuto de variaveis que compoe um documento
// Initial-Only: São variaveis que só podem ser atribuido valor na inicialização, não poderam ser modificadas depois
// GetHashCode: Método utilizado para comparar objetos por valor, por exemplo dois objetos diferentes mas com valores iguais exemplo: documento1.GetHashCode().Equals(Documento2.GetHashCode())

// Comparação de records
// Comparando dois registros criados com dados iguais
var documento1 = new Documento
{
    Numero = 123456
};

var documento2 = new Documento
{
    Numero = 123456
};

var igual = documento1.Equals(documento2);
Console.WriteLine("******* Value-based equality - Igualdade baseada em valor *******");
Console.WriteLine();
Console.WriteLine($"Comparação de objetos diferentes (do mesmo registro) com dados iguais: {igual}");
igual = documento1.GetHashCode().Equals(documento2.GetHashCode());
Console.WriteLine($"Comparação de Hash Codes de objetos diferentes (do mesmo registro) com dados iguais: {igual}");

// Comparação de records com herança
// Comparando um registro criado pela registro base e outro criado pelo registro derivado
var rg1 = new Documento
{
    Numero = 123456
};

var rg2 = new RG
{
    Numero = 123456,
    OrgaoExpeditor = "SSP"
};

igual = rg1.Equals(rg2);
Console.WriteLine($"Comparação de objetos diferentes (registro base X registro derivado) com dados iguais: {igual}");

Console.WriteLine();
Console.WriteLine("******* Positional records - Registros Posicionais *******");
var previsaoTempo = new PrevisaoTempo(10.9m, 65.5m);
var (temperatura, umidade) = previsaoTempo;
Console.WriteLine($"Temperatura: {temperatura}ºC | Umidade: {umidade}%");