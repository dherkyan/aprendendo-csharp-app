using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Controle.Operadores
{
    class AprendendoOperadorCoalescing
    {
        public static void Mainx(string[] args)
        {
            string nome = null;

            Console.WriteLine(nome ?? "Nome Não definido");
        }
    }
}
