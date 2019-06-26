using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.PalavrasChave
{
    class PessoaThis
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public PessoaThis(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public static void Mainx(string[] args)
        {
            PessoaThis pessoa = new PessoaThis("Bia", 123);
            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Idade);
        }

    }
}
