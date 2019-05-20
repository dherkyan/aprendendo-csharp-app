using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Controle.Switch
{
    class AprendendoSwitch : IMain
    {
        public void Excutar()
        {
            int i = 1;

            switch (i)
            {
                case 0:
                    Console.WriteLine("Case {0}",i);
                    break;
                case 1:
                    Console.WriteLine("Case {0}", i);
                    break;
                case 2:
                    Console.WriteLine("Case {0}", i);
                    break;
                default:
                    Console.WriteLine("Case default", i);
                    break;
            }
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Aprendendo switch");
        }
    }
}
