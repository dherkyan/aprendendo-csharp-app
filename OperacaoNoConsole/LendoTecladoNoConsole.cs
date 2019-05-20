using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.OperacaoNoConsole
{
    class LendoTecladoNoConsole : IMain
    {
        public void Excutar()
        {
            Titulo();
            Console.Write("Informe se nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá, {0}", nome);
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Lendo o teclado no console");
        }
    }
}
