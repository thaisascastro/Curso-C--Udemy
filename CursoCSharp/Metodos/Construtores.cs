using System;
namespace CursoCSharp.Metodos
{
    class Carro
    {
        public string Modelo;
        public string Marca;
        public int Ano;

        public Carro(string modelo, string marca, int ano)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
        }

        public Carro()
        {
            // classe car
        }

    }

    class Construtores
    {
        public static void Executar()
        {
            // construtor padrão
            var carro1 = new Carro();
            carro1.Marca = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;
            Console.WriteLine($"{carro1.Marca}, {carro1.Modelo}, {carro1.Ano}.");

            var carro2 = new Carro("Ka", "Ford", 2018);
            Console.WriteLine($"{carro2.Marca}, {carro2.Modelo}, {carro2.Ano}");

            var carro3 = new Carro()
            {
                Modelo = "Uno",
                Marca = "FIAT",
                Ano = 2020
            };
            Console.WriteLine($"{carro3.Marca}, {carro3.Modelo}, {carro3.Ano}");
        }
    }
}
