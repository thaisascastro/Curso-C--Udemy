﻿using System;
namespace CursoCSharp.Fundamentos
{
    class OperadoresTernarios
    {
        public static void Executar()
        {
            var nota = 7.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento
                ? "Aprovado" : "Reprovado";

            Console.WriteLine(resultado);

            // separador é ?
            // && = e
        }
    }
}
