﻿using System;
namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}.", numero);

            for(int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o número que queremos? ", i);
                if(i == numero)
                {
                    Console.WriteLine("Sim!");
                    break;
                } else
                {
                    Console.WriteLine("Não!");
                }
            }
            Console.WriteLine("Fim!");
        }
    }
}
