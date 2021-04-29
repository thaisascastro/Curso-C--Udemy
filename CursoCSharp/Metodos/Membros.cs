using System;
namespace CursoCSharp.Metodos
{
     class Membros
     {
         public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Thaísa";
            sicrano.Idade = 21;

            //Console.WriteLine($"{sicrano.Nome}, têm {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Leandro";
            fulano.Idade = 20;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano.Length);
            Console.WriteLine(apresentacaoDoFulano);
        }
         
     }
}
