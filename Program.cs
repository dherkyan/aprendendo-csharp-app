using AprendendoCSharpApp.Controle.If;
using AprendendoCSharpApp.OperacaoNoConsole;

namespace AprendendoCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            new ExibindoMensagemNoConsole().Excutar();
            new LendoTecladoNoConsole().Excutar();
            new AprendendoIfElse().Excutar();
            new AprendendoIf().Excutar();
        }
    }
}
