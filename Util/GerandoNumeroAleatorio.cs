using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Util
{
    class GerandoNumeroAleatorio : ISistema
    {
        public void Excutar()
        {
            Random random = new Random();
            for (int i = 0; i < 5;i++)
            {
                Console.WriteLine("Numero : {0}", random.Next(1000));
            }
        }

        public void Titulo()
        {
            Utilitario.Mensagem("GerandoNumeroAleatorio...");
        }
    }
}
