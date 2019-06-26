using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Controle.Operadores
{
    class AprendendoOperadorLambdaCorpo
    {
        public static void Mainx(string[] args)
        {
            MensagemCapitaoAmerica();
            MensagemHomemDeFerro();
        }

        private static void MensagemCapitaoAmerica()
        {
            Console.WriteLine("Capitão América: Precisamos de um plano de ataque!");
        }

        private static void MensagemHomemDeFerro() => Console.WriteLine("Homem de Ferro: Eu tenho um plano. Ataque.");
    }
}
