using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Heranca
{
    abstract class ClasseAbstrata
    {
        public abstract void Calcular();

        public void Total()
        {
            Console.WriteLine("ClasseAbstrata - Total");
        }

    }
}
