using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Collections
{
    class AprendendoHashSet : ISistema
    {
        public void Excutar()
        {

            ISet<string> palavras = new HashSet<string>();

            string palavra = Console.ReadLine();

            while (!palavra.ToLower().Equals("fim"))
            {
                if (palavras.Add(palavra))
                {
                    Console.WriteLine($"{palavra} foi adicionado na lista...");
                }
                else
                {
                    Console.WriteLine($"{palavra} NÃO foi adicionado na lista...");
                }
                palavra = Console.ReadLine();
            }

            Console.WriteLine("Programa finalizado...");
        }

        public void Titulo()
        {
            Console.WriteLine("Aprendendo HashSet...");
        }
    }
}
