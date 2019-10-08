using System;
using System.IO;

namespace AprendendoCSharpApp.Exceptions
{
    public class ArquivMultiCatchException
    {
        public static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = File.OpenText("C:/VisualStudioProjects/aprendendo-csharp-app/filme.txt"))
                {
                    Console.WriteLine($"Titulo {sr.ReadLine()}");
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine($"Arquivo Não encontrado: '{e}'");
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"Diretorio não encontrado: '{e}'");
            }
            catch (IOException e)
            {
                Console.WriteLine($"Arquivo não pode ser aberto: '{e}'");
            }
        }
    }
}
