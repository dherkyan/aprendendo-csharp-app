using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Encapsulamento
{
    class AcessibilidadeComHeranca : AcessarAtributos
    {
      

        void AtributosAcessiveis()
        {
            Console.WriteLine(AtributoPrivateProtected);
            Console.WriteLine(AtributoProtected);
            Console.WriteLine(AtributoProtectedInternal);
            Console.WriteLine(AtributoInternal);
            Console.WriteLine(AtributoPublico);
        }

        public static void Main(string[] args)
        {
            new AcessibilidadeComHeranca().AtributosAcessiveis();
        }



    }
}
