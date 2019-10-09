using System;
using System.Collections.Generic;

namespace AprendendoCSharpApp.Collections
{
    class UtilzandoColecaoSet
    {
        public static void Main(string[] args)
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
    }
}
