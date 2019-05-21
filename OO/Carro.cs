using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.OO
{
    class Carro
    {
        public string placa { get; set; }

        public Carro()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Carro carro &&
                   placa == carro.placa;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(placa);
        }
    }
}
