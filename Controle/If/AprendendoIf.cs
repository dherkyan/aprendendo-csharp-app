
using System;

namespace AprendendoCSharpApp.Controle.If
{
    class AprendendoIf : ISistema
    {

        public AprendendoIf()
        {
            Titulo();
        }

        public void Excutar()
        {
            bool expressao = 1 < 2;
            if (expressao)
            {
                Console.WriteLine("Exepressão Verdadeira...");
            }
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Aprendendo if");
        }
    }
}
