using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Controle.If
{
    class AprendendoIfElse : ISistema
    {
        public void Excutar()
        {
            Titulo();
            bool expressao = 10 < 1;
            if (expressao)
            {
                Console.WriteLine("Expressão verdadeira...");
            }
            else
            {
                Console.WriteLine("Expressão falsa...");
            }
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Aprendendo if else");
        }
    }
}
