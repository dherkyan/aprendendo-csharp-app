using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Loop
{
    class AprendendoFor : IMain
    {
        public void Excutar()
        {
            Titulo();
            for (int i = 0; i < 10;i++)
            {
                Console.WriteLine("Indice {0}",i);
            }
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Aprendendo for");
        }
    }
}
