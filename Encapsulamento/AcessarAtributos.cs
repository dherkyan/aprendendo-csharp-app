using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.Encapsulamento
{
    class AcessarAtributos
    {

        string AtributoPrivateImplicito = "AtributoPrivateExplicito";

        private string AtributoPrivateExplicito = "AtributoPrivateExplicito";

        private protected string AtributoPrivateProtected = "AtributoPrivateProtected";

        // O acesso é limitado à classe que os contém ou aos tipos derivados da classe que os contém.
        protected string AtributoProtected = "AtributoProtected";

        internal string AtributoInternal = "AtributoInternal";

        protected internal string AtributoProtectedInternal = "AtributoProtectedInternal";

        // O acesso não é restrito.
        public string AtributoPublico = "AtributoPublico";

    }
}
