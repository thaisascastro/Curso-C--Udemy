﻿using System;
namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.Write("Avalie seu conhecimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                    Console.WriteLine("Ruim");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    Console.WriteLine("Parabéns!");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
            }

           Console.WriteLine("Obrigada pela resposta!");
        }
    }
}
