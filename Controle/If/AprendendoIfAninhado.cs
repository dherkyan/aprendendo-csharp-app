using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Controle.If
{
    class AprendendoIfAninhado : ISistema
    {
        public void Excutar()
        {
            int x = 10;
            if (x < 5)
            {
                Console.WriteLine("if nivel 1");
                if (x < 8)
                {
                    Console.WriteLine("if nivel 2");

                }
            }
        }

        public void Titulo()
        {
            Console.WriteLine("Aprendendo if aninhado");
        }
    }
}
