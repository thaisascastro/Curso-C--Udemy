using System;
namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 3456.60;

            Console.WriteLine("O " + nome + " dá marca " + marca + " custa R$ " + preco + ".");
            Console.WriteLine("O {0} dá marca {1} custa R${2}.", nome, marca, preco);
            Console.WriteLine($"O {nome} dá marca {marca}, custa R${preco}.");
            Console.WriteLine($"Se somar 1 + 7 = {1 + 7}.");

        }
    }
}
