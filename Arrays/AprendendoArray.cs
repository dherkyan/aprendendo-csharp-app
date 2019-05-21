using System;

namespace AprendendoCSharpApp.Arrays
{
    class AprendendoArray : ISistema
    {
        public void Excutar()
        {

            int[] numeros = new int[3];

            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;

            Console.WriteLine("Tamanho array: {0}",numeros.Length);

            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }


            string[] letras = { "A", "B", "C" };

            Console.WriteLine("Tamanho array: {0}", letras.Length);

            foreach (string s in letras)
            {
                Console.WriteLine(s);
            }

        }

        public void Titulo()
        {
            Utilitario.Mensagem("Aprendendo Array");
        }
    }
}
