using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Collections
{
    public class Pessoa
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Pessoa pessoa &&
                   Cpf == pessoa.Cpf;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Cpf);
        }
    }
}
