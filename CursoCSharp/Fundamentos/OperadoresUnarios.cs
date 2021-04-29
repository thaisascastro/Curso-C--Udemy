using System;
namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var valor1 = 2;
            var valor2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // ele inverte o valor que estiver
            Console.WriteLine(!booleano);

            valor1++;
            Console.WriteLine(valor1);

            --valor1;
            Console.WriteLine(valor1);

            Console.WriteLine(valor1++ == --valor2);
            // se você colocar o número valor1++ ele será feito depois,
            // se você colocar o numero --valor1 o incremento primeiro, será feito 1º
            Console.WriteLine($"{valor1} e {valor2}");
        }
    }
}
