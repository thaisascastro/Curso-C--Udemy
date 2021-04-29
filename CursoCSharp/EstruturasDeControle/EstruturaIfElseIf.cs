using System;
namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua nota aqui: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if(nota >= 9.0)
            {
                Console.WriteLine("Você foi aprovado!");
                Console.WriteLine("Quadro de horna!");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Recuperação");
            }
            else {
                Console.WriteLine("Nos vemos no outro ano!");
            }

            Console.WriteLine("Fim!!");
        }
    }
}
