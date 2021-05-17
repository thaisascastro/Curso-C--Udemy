using System;
namespace CursoCSharp.Metodos
{
    class ParametrosVariaveis
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Olá {0}.", pessoa);
            }
        }

       public static void Executar()
        {
            Recepcionar("Thaísa", "Leandro", "Bia", "Jusi", "Osvaldo", "Rato");
        }
    }
}
