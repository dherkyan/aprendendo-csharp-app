using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Exceptions
{
    class AprendendoTryFinally
    {
        public static void Mainx(string[] args)
        {
            int[] numeros = { 1, 2 };

            try
            {
                Console.WriteLine(numeros[10]);
            }
            finally
            {
                Console.WriteLine("Bloco finally...");
            }
        }
    }
}
