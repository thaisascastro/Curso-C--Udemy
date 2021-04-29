using System;
namespace CursoCSharp.Fundamentos
{
    class OperadoresDeAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 += 7;
            num1 += 10; // num1 = num1 + 10;
            num1 -= 3; // num1 = num1 - 3;
            num1 *= 4; // num1 = num1 * 4;
            num1 /= 2; // num1 = num1 / 2;

            Console.WriteLine("O resultado é {0} ", num1);

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine($"{a} {b}");

            // Algo como Ponteiros do C
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "Thaísa";

            dynamic d = c;
            d.nome = "Leandro";

            Console.WriteLine($"{c.nome} {d.nome}");
        }
    }
}
