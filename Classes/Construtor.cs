using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Classes
{
    public class Construtor
    {
        private string Nome { get; set; }
        private int Versao { get; set; }

        public Construtor()
        {
        }

        public Construtor(int versao) => Versao = versao;

        public Construtor(string nome, int versao)
        {
            Nome = nome;
            Versao = versao;
        }

        public static void Main(string[] args) {
            Construtor c = new Construtor("Construtor 1", 1);
            Construtor c2 = new Construtor(10);

            Console.WriteLine(c.Nome +" - "+c.Versao);
            Console.WriteLine(c2.Versao);
        }
    }
}
