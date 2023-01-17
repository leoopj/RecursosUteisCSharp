namespace ExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mensagem = "Hello Word!";
            var mensagemInvertida = mensagem.Revert();

            Console.WriteLine($"Mensagem Original: {mensagem}");
            Console.WriteLine($"Mensagem Invertida: {mensagemInvertida}");
        }
    }
}

