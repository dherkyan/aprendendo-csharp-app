using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Controle.If
{
    class AprendendoIfTernario : ISistema
    {
        public void Excutar()
        {
            string resultado = 1 == 2 ? "Sim" : "Não";
            Console.WriteLine("Resultado: {0}", resultado);
        }

        public void Titulo()
        {
            Console.WriteLine("Aprendendo if ternario");
        }
    }
}
