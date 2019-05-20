using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Loop
{
    class AprendendoForeach : IMain
    {
        public void Excutar()
        {
            Titulo();
            int[] numeros = { 1, 2, 3, 4, 5 };
            foreach (int numero in numeros)
            {
                Console.WriteLine("Número: {0}",numero);
            }
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Aprendendo foreach");
        }
    }
}
