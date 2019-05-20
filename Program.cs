using AprendendoCSharpApp.Controle.If;
using AprendendoCSharpApp.Design;
using AprendendoCSharpApp.IO;
using AprendendoCSharpApp.Loop;
using AprendendoCSharpApp.OperacaoNoConsole;
using AprendendoCSharpApp.Pacote;

namespace AprendendoCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            new ExibindoMensagemNoConsole().Excutar();
            new LendoTecladoNoConsole().Excutar();
            new AprendendoIfElse().Excutar();
            new AprendendoIf().Excutar();
            new AprendendoFor().Excutar();
            new AprendendoForeach().Excutar();
            new AprendendoWhile().Excutar();
            new AprendendoDoWhile().Excutar();
            new OperacoesComEnum().Excutar();
            new AprendendoStrings().Excutar();
            new LerArquivos().Excutar();
            new OperacoesComFile().Excutar();
            */
            new EscreverArquivo().Excutar();
            

        }
    }
}
