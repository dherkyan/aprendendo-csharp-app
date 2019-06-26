using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Loop
{
    class AprendendoForIn
    {
        public static void Mainx(string[] args)
        {
            Span<int> numeros = new int[] { 1, 5, 15, 20, 40 };
            foreach (int numero in numeros)
            {
                Console.Write($"{numero} ");
            }
        }
    }
}
