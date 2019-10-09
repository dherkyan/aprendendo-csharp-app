using System;
using System.Collections.Generic;

namespace AprendendoCSharpApp.Collections
{
    public class ColecaoSetPessoas
    {
        public static void Main(string[] args)
        {
            HashSet<Pessoa> pessoas = new HashSet<Pessoa>();

            var ana = new Pessoa() { Cpf = "011.111.111-11", Nome = "Ana" };
            var anaPaula = new Pessoa() { Cpf = "011.111.111-11", Nome = "Ana Paula" };
            var bob = new Pessoa() { Cpf = "011.222.222-22", Nome = "Bob" };

            pessoas.Add(ana);
            pessoas.Add(bob);

            //pessoas.Add(anaPaula);

            Console.WriteLine("Contem: "+pessoas.Contains(anaPaula));

        }

    }
}
