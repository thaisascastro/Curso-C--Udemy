﻿using System;
namespace CursoCSharp.Metodos
{
    class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar()
        {
            Formatar(mes: 12, dia: 7, ano: 2018);
        }
    }
}
