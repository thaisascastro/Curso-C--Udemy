using System;
namespace CursoCSharp.Fundamentos
{
   class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // nao pode! PI = 3.141;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + (area * 1000));

            // Tipos Internos
            // booleanos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            // INTEIRO
            // Um único byte, aceita valores +
            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            // Aceita valores negativos
            sbyte saldoDeGols = sbyte.MinValue; /*menor valor do byte*/
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            // dois bytes
            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            // mais usados dos inteiros /
            // quatro bytes
            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor inteiro " + menorValorInt);

            // inteiro sem sinal
            uint populucaoBrasileira = 207_600_350;
            Console.WriteLine("População brasileira " + populucaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong maiorValorUlong = long.MaxValue;
            Console.WriteLine("Maior valor long " + maiorValorUlong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial " + populacaoMundial);

            // Pontos Flutuantes
            float precoComputador = 1299.99F; /* para falar que armazena float */
            Console.WriteLine("Preço do Computador " + precoComputador);

            double valorMercadoDaApple = 1_000_000_000_000; // Mais usado
            Console.WriteLine("Valor Apple " + valorMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
