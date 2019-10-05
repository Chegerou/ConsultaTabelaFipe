using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TabelaFipeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tabelaFipe = new TabelaFipe.Model.TabelaFipe("carros", "Fiat", "Palio 1.0");

            var teste = tabelaFipe.RetornarVeiculo();

        }
    }
}
