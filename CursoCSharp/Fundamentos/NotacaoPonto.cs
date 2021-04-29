using System;
namespace CursoCSharp.Fundamentos
{
     class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá".ToUpper().Insert(3, " World!")
                .Replace("World!", "Mundo!");
            // resultado é : OLÁ Mundo!
            // ToUpper = tudo maiúsculo.
            // Insert = inserir no elemento ?.
            // Replace = modificar.
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
