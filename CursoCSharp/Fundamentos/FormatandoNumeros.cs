using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            // para formatar um número só, depois da Vírgula.
            Console.WriteLine(valor.ToString("C"));
            // transformar em valor monetário
            Console.WriteLine(valor.ToString("P"));
            // transformar em percentual
            Console.WriteLine(valor.ToString("#.##"));
            // formatar mostrando depois dá vírgula, dois.

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultura));

            CultureInfo cultura1 = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C3", cultura1));

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
