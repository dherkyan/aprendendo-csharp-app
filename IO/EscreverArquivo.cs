using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AprendendoCSharpApp.IO
{
    class EscreverArquivo : ISistema
    {
        public void Excutar()
        {
            Titulo();
            string Path = "C:/Curso/aprendendo-csharp-app/arquivo.txt";
            Stream stream = File.Open(Path, FileMode.Create);
            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("Nova linha de texto");

        }

        public void Titulo()
        {
            Utilitario.Mensagem("Escrevendo no arquivo");
        }
    }
}
