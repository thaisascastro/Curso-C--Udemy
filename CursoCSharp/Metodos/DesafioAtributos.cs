using System;
namespace CursoCSharp.Metodos
{
    class DesafioAtributos
    {
        int a = 10;
        string nome = "Thaísa";
        double desconto = 100.0;

        public static void Executar()
        {
            DesafioAtributos desafio = new DesafioAtributos();
            Console.WriteLine(desafio.a);
            Console.WriteLine(desafio.nome);
            Console.WriteLine(desafio.desconto);

        }
    }
}
