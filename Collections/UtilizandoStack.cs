using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Collections
{
    public class UtilizandoStack
    {
        public static void Main(string[] args)
        {
            Stack<string> nomes = new Stack<string>();
            nomes.Push("Ana");
            nomes.Push("Bruna");
            nomes.Push("Carla");

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
                if (nome.Equals("Bruna"))
                {
                    nomes.Pop();
                }
            }

           

            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }

        }

    }
}
