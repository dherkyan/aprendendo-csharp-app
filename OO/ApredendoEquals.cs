using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.OO
{
    class ApredendoEquals : Sistema
    {
        public ApredendoEquals() : base("Aprendendo Equals")
        {

        }

        public override void Excutar()
        {

            Carro gol = new Carro();
            gol.placa = "AAA-1234";

            Carro polo = new Carro();
            polo.placa = "AAA-1234";

            Console.WriteLine("Gol equals Polo: {0}", gol.Equals(polo));

        }

        public override void Titulo()
        {

        }
    }
}
