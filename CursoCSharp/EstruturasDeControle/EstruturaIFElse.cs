using System;
namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIFElse
    {
       public static void Executar()
        {
            double nota = 7.0;

            if (nota >= 7)
            {
                Console.WriteLine("Você foi aprovado!");
                Console.WriteLine("Fez mais que sua obrigação");
            }

            else
            {
                Console.WriteLine("Você reprovou!!");
            }
        }
    }
}
