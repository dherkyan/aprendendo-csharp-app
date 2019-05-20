using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Controle.If
{
    class AprendendoIfEncadeado : IMain
    {
        public void Excutar()
        {
            int x = 18;
            if (x < 18)
            {
                Console.WriteLine("x menor que 18");
            }else if (x == 18)
            {
                Console.WriteLine("x igual a 18");
            }
            else
            {
                Console.WriteLine("x maior a 18");
            }
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Aprendendo if else encadeado");
        }
    }
}
