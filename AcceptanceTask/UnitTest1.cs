using AprendendoCSharpApp.Task;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcceptanceTask
{
    [TestClass]
    public class TestarClasseOpetaracaoMatematica
    {
        [TestMethod]
        public void MetodoSomarCorreto()
        {
            int total = OperacaoMatematica.Somar(2, 2);
            Assert.AreSame(4, total);
        }
    }
}
