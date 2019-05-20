using System;


namespace AprendendoCSharpApp.OperacaoNoConsole
{
    class ExibindoMensagemNoConsole : IMain
    {
        public void Excutar()
        {
            Titulo();

            Console.Write("Texto sem quebra de linha");
            Console.WriteLine("Texto com quebra de linnha...");
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Exibindo mensagem no console...");
        }
    }
}
