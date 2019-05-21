using System;
using System.Collections.Generic;
using AprendendoCSharpApp.Arrays;
using AprendendoCSharpApp.Controle.If;
using AprendendoCSharpApp.Design;
using AprendendoCSharpApp.IO;
using AprendendoCSharpApp.Loop;
using AprendendoCSharpApp.OO;
using AprendendoCSharpApp.OperacaoNoConsole;
using AprendendoCSharpApp.Pacote;

namespace AprendendoCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ISistema> sistemas = new List<ISistema>();

            sistemas.Add(new ExibindoMensagemNoConsole());
            sistemas.Add(new LendoTecladoNoConsole());
            sistemas.Add(new AprendendoIfElse());
            sistemas.Add(new AprendendoIf());
            sistemas.Add(new AprendendoFor());
            sistemas.Add(new AprendendoForeach());
            sistemas.Add(new AprendendoWhile());
            sistemas.Add(new AprendendoDoWhile());
            sistemas.Add(new OperacoesComEnum());
            sistemas.Add(new AprendendoStrings());
            sistemas.Add(new LerArquivos());
            sistemas.Add(new OperacoesComFile());
            sistemas.Add(new ExibindoMensagemNoConsole());
            sistemas.Add(new LendoTecladoNoConsole());
            sistemas.Add(new EscreverArquivo());
            sistemas.Add(new AprendendoArray());
            sistemas.Add(new ApredendoEquals());



            //sistemas.ForEach(s => s.Excutar());
        }
    }
}
