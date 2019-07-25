using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Heranca
{
    class ClasseAbstrataImpl : ClasseAbstrata
    {

        public static void Main(string[] args)
        {
            ClasseAbstrataImpl impl = new ClasseAbstrataImpl();
            impl.Total();

            ClasseAbstrata ca = new ClasseAbstrataImpl();
            ca.Total();
        }

        public override void Calcular()
        {
            Console.WriteLine("ClasseAbstrataImpl - Calcular");
        }

        public new void Total()
        {
            Console.WriteLine("ClasseAbstrataImpl - Total");
        }

    }
}
