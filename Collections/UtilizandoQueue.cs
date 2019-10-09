using System;
using System.Collections.Generic;


namespace AprendendoCSharpApp.Collections
{
    public class UtilizandoQueue
    {
        public static void Main(string[] args)
        {
            Queue<string> nomes = new Queue<string>();
            nomes.Enqueue("Ana");
            nomes.Enqueue("Bruna");
            nomes.Enqueue("Carla");

            foreach (string nome in nomes)
            {
                Console.WriteLine("Quantidade nomes: " + nomes.Count);
                nomes.Dequeue();
            }

            Console.WriteLine("Quantidade nomes: "+nomes.Count);
        }
    }
}
