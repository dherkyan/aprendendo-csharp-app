using System;
using System.Collections.Generic;

namespace AprendendoCSharpApp.Collections
{
    public class ColecaoListMetodos
    {
        public static void Main(string[] args)
        {
            var ana = new Pessoa() { Cpf = "011.111.111-11", Nome = "Ana" };
            var bob = new Pessoa() { Cpf = "011.222.222-22", Nome = "Bob" };
            var anaAlice = new Pessoa() { Cpf = "011.111.111-11", Nome = "Ana Alice" };

            List<Pessoa> pessoas = new List<Pessoa>();

            pessoas.Add(ana);
            pessoas.Add(bob);
            pessoas.Add(anaAlice);

            Console.WriteLine("Quantidade de pessoas na lista: " + pessoas.Count);


            Console.Write("Procurando pessoa com nome Ana: ");
            Pessoa pessoa = pessoas.Find(p => p.Nome.Contains("Ana"));
            Console.WriteLine(pessoa.Nome);


            Console.Write("Procurando a última pessoa com nome Ana: ");
            Pessoa ultimaAna = pessoas.FindLast(p => p.Nome.Contains("Ana"));
            Console.WriteLine(ultimaAna.Nome);


            Console.Write("Procurando por Bob: ");
            int index = pessoas.IndexOf(bob);
            Console.WriteLine(index);

            Console.Write("Bob foi removido da lista? ");
            bool removido = pessoas.Remove(bob);
            Console.WriteLine(removido);

            Console.Write("A lista contem alguem com o cpf: 011.111.111-11 ? ");
            bool existe = pessoas.Exists(p => p.Cpf.Equals("011.111.111-11"));
            Console.WriteLine(existe);

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine("{0} {1}", p.Cpf, p.Nome);
            }

        }
    }
}
