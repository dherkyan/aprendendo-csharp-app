using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.PalavrasChave
{
    class AprendendoIs
    {
        public static void Mainx(string[] args)
        {
            SmartPhone s9 = new SmartPhone();
            Eletronico j6 = new SmartPhone();
            Eletronico k10 = new Eletronico();

            Console.WriteLine(s9 is Eletronico);
            Console.WriteLine(j6 is Eletronico);
            Console.WriteLine(k10 is SmartPhone);
        }

    }
}
