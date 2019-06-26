using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AprendendoCSharpApp.Controle.Operadores
{
    class AprendendoOperadorLambda
    {
        public static void Mainx(string[] args)
        {
            string[] nomes = { "carla", "bia", "bianca","andrea" };
            IEnumerable<string> nomesFiltrados = nomes.Where(nome => nome.StartsWith("b"));

            foreach (string nome in nomesFiltrados)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
