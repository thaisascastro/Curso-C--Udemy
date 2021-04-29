using System;
namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preco Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var TotalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é {TotalComDesconto}.");

            // IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / Math.Pow(altura, 2);
            // double imc = peso / (altura * altura);
            Console.WriteLine("IMC é {0}.", imc);

            // Número Par/Ímpar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par & 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar & 2);
        }
    }
}
