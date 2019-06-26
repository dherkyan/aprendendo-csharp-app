using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Exceptions
{
    class AprendendoTryCatchFinally
    {
        public static void Mainx(string[] args)
        {
            int[] numeros = { 1, 2 };

            try
            {
                Console.WriteLine(numeros[10]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Posição não existe...");
            }
            finally
            {
                Console.WriteLine("Bloco finally...");
            }
        }
    }
}
