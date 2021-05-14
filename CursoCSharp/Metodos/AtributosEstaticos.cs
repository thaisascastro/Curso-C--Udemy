using System;
namespace CursoCSharp.Metodos
{
    public class Produto
    {
        public string Nome;
        public int Preco;
        public double Desconto = 0.1;

    }
     class AtributosEstaticos
    {
        public static void Executar()
        {
            Console.WriteLine("Atributos Estáticos");
        }
    }
}
