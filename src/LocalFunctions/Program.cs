using System;
using System.Linq;

namespace LocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Local function utilizado para criação de métodos dentro de outro método, não sendo exposto na camada externa, usabilidade recomendada em casos de metódos que precisam ser chamadas diversas vezes em um unico lugar e não precisa expor aos outros
            string Inverter(string valor) 
            {
                return new string(
                    valor.ToCharArray().Reverse().ToArray());
            }

            string texto;

            texto = "Utilizando o C#";
            Console.WriteLine($"{texto} -> {Inverter(texto)}");

            texto = "Local Function";
            Console.WriteLine($"{texto} -> {Inverter(texto)}");

            Console.ReadKey();
        }
    }
}