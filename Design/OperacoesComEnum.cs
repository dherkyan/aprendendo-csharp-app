using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Design
{
    class OperacoesComEnum : ISistema
    {
        public void Excutar()
        {
            string[] values = Enum.GetNames(typeof(AprendendoEnum));

            foreach (string nome in values)
            {
                Console.WriteLine("Nomes enums: {0}", nome);
            }

            foreach (Enum value in Enum.GetValues(typeof(AprendendoEnum)))
            {
                Console.WriteLine("Nomes enums: {0}", value);
            }

        }

        public void Titulo()
        {
            Utilitario.Mensagem("Operações com enum");
        }
    }
}
