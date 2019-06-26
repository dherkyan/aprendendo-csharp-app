using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpApp.PalavrasChave
{
    class CarroGetSet
    {
        public string Modelo { get; set; }
        private string _placa;
        private int _ano;
        private string _cor;
        private string Marca;

        public string Placa
        {
            get => _placa;
            set => _placa = value;
        }

        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }

        public string Cor
        {
            get
            {
                return _cor;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _cor = value;
                }
                else
                {
                    _cor = "Cor não definida";
                }
            }
        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public static void Mains(string[] args)
        {
            CarroGetSet carro = new CarroGetSet();
            carro.Placa = "ZZZ-1111";
            carro.Modelo = "G City";
            carro.Ano = 2019;
            carro.Cor = "";
            carro.SetMarca("VW");

            Console.WriteLine(carro.Placa);
            Console.WriteLine(carro.Modelo);
            Console.WriteLine(carro.Ano);
            Console.WriteLine(carro.Cor);
            Console.WriteLine(carro.GetMarca());

        }
    }
}
