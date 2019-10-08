using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Exceptions
{
    public class ValidadorEmail
    {

        public static void Main(string[] args)
        {
            try
            {
                ValidarEmail();
            }
            catch (EmailNaoContemArrobaException e)
            {
                Console.WriteLine("O Email informado não contém @. " + e.Message);
            }
            catch (EmailNaoTerminaComBrException e)
            {
                Console.WriteLine("O Email informado não termina com br " + e.Message);
            }

        }

        public static void ValidarEmail()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();

            if (!email.Contains("@"))
            {
                throw new EmailNaoContemArrobaException();
            }
            if (!email.ToLower().EndsWith(".br"))
            {
                throw new EmailNaoTerminaComBrException();
            }
        }


    }
}
