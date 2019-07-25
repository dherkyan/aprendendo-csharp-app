using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Pacote
{
    class AprendendoStrings : ISistema
    {
        public void Excutar()
        {
            string texto = "  Precisamos de um plano de ataque ! Eu tenho um plano. Ataque.  ";

            Console.WriteLine(texto.ToUpper());

            Console.WriteLine(texto.ToLower());

            Console.WriteLine("A frase começa com Precisamos: {0}", texto.StartsWith("Precisamos"));

            Console.WriteLine("A frase termina com Ataque.: {0}", texto.EndsWith("Ataque."));

            foreach (string txt in texto.Split("ataque"))
            {
                Console.WriteLine(txt);
            }

            Console.WriteLine(texto.Replace("plano", "Super Plano"));

            Console.WriteLine("Quantidade de caracteres: {0}",texto.Length);

            Console.WriteLine(texto.Trim());

            Console.WriteLine(texto.TrimStart());

            Console.WriteLine(texto.TrimEnd());

            Console.WriteLine(texto.Substring(texto.Length / 2));

            Console.WriteLine("Texto contém a palavra plano? {0}",texto.Contains("plano"));

            Console.WriteLine("Posição palavra um {0}",texto.IndexOf("um"));

            Console.WriteLine(texto.ToUpperInvariant());
            
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Aprendeno string...");
        }

        public string ConverterTextoParaMaiusculo(string texto)
        {
            return texto.ToUpper();
        }
    }
}
