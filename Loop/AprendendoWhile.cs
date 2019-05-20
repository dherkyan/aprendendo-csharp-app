using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Loop
{
    class AprendendoWhile : IMain
    {
        public void Excutar()
        {

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        public void Titulo()
        {
            Utilitario.Mensagem("Aprendendo while");
        }
    }
}
