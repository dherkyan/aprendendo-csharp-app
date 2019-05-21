using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Loop
{
    class AprendendoDoWhile : ISistema
    {
        public void Excutar()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Aprendendo do while");
        }
    }
}
