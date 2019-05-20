using System;
using System.IO;

namespace AprendendoCSharpApp.IO
{
    class OperacoesComFile : IMain
    {
        public void Excutar()
        {
            string Path = "C:/Curso/aprendendo-csharp-app/arquivo.txt";

            Console.WriteLine("Arquivo existe: {0}", File.Exists(Path));


            string PathBalanco = "balanco.txt";

            FileStream file = File.Create(PathBalanco);
            file.Close();

            File.Delete(PathBalanco);
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Operações com a Classe File");

        }
    }
}
