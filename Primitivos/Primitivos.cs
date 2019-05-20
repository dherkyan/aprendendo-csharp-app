using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Primitivos
{
    class Primitivos : IMain
    {
        public void Excutar()
        {
            bool Bools = true;
            byte Bytes = 0;
            int Ints = 0;
            uint UInts = 0;
            long Longs = 0;
            ulong ULongs = 0;
            float Floats = 0.0f;
            double Doubles = 0;
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Primitivos básicos");
        }
    }
}
