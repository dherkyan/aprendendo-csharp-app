using System;

namespace AprendendoCSharpApp
{
    public abstract class Sistema : ISistema
    {
        public string titulo {get; set;}

        protected Sistema(string titulo) => this.titulo = titulo;

        public abstract void Excutar();
        public abstract void Titulo();
    }
}
