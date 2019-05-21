using System;

namespace AprendendoCSharpApp.Util
{
    class AprendendoConversao : ISistema
    {
        public void Excutar()
        {
            int numeroInt = Convert.ToInt32("23");
        }

        public void Titulo()
        {
            Utilitario.Mensagem("Aprendendo a converter dados");
        }
    }
}
