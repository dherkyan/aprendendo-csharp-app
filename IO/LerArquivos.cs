using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AprendendoCSharpApp.IO
{
    class LerArquivos : IMain
    {
        public void Excutar()
        {
            Titulo();
            string path = "C:/Curso/aprendendo-csharp-app/arquivo.txt";

            Stream stream = File.OpenRead(path);
            StreamReader reader = new StreamReader(stream);

            string texto = null;
            do
            {
                Console.WriteLine(texto);
                texto = reader.ReadLine();

            } while (texto != null);
            stream.Close();
            reader.Close();
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Lendo arquivos");
        }
    }
}
