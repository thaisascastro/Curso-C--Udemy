using System;
namespace CursoCSharp.Metodos
{
   class Pessoa
    {
        // visível
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome}, tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }

        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }

    }
}
