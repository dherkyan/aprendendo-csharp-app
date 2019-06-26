using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.OO
{
    class AprendendoEqualsHashCode
    {
        public string Codigo { get; set; }

        public static void Main(string[] args)
        {

            AprendendoEqualsHashCode objeto1 = new AprendendoEqualsHashCode()
            {
                Codigo = "021"
            };

            AprendendoEqualsHashCode objeto2 = new AprendendoEqualsHashCode()
            {
                Codigo = "021"
            };

            Console.WriteLine(objeto1 == objeto2);
            Console.WriteLine(objeto1.Equals(objeto2));
            Console.WriteLine(objeto1.GetHashCode());
            Console.WriteLine(objeto2.GetHashCode());
        }

        public override bool Equals(object obj)
        {
            AprendendoEqualsHashCode app = (AprendendoEqualsHashCode) obj;
            return Codigo.Equals(app.Codigo);
        }

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }
    }
}
