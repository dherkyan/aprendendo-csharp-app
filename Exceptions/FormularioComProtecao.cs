using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Exceptions
{
    class FormularioComProtecao
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Olá {nome}, você tem {idade} anos.");

            }
            catch (FormatException e)
            {
                Console.WriteLine("Idade inválida...");
                Console.WriteLine(e.Message);
            }
        }
    }
}
