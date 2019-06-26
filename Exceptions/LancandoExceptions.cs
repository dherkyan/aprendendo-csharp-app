using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Exceptions
{
    class LancandoExceptions
    {
        public static void Mainx(string[] args)
        {
            int i = 10;

            if (i == 10)
            {
                throw new ArgumentNullException();
            }
        }

    }
}
