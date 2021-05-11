using System;
namespace CursoCSharp.Metodos
{
    public class CalculadoraEstatica
    {
        // Método Classes ou Método Estático
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Método de Instância
        public int Somar(int a, int b)
        {
            return a + b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 4);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calcular = new CalculadoraEstatica();
            Console.WriteLine(calcular.Somar(2, 7));
        }
    }
}
