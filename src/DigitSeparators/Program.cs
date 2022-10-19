const int LETRA_Y_BIN = 0b01_01_10_01; //Definição de binário (01011001) = 89 (decimal)
const int LETRA_Z_HEX = 0X5_A; //Definição hexadecimal, 5A (hexadecimal) = 80 (decimal)
const int POPULACAO_ESTIMADA_BRASIL = 204_500_000;
const double RENDA_PER_CAPITA_BRASIL_USD = 11_208;

Console.WriteLine("Valor numérico");
Console.WriteLine($"Y = {LETRA_Y_BIN}");
Console.WriteLine($"Z = {LETRA_Z_HEX}");
Console.WriteLine(string.Empty);
Console.WriteLine($"População estimada do Brasil = {POPULACAO_ESTIMADA_BRASIL}");
Console.WriteLine($"Renda per capta do Brasil (US$) = {RENDA_PER_CAPITA_BRASIL_USD}");
Console.ReadKey();