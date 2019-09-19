using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabelaFipeProject;

namespace TabelaFipeProjectTest
{
    [TestClass]
    public class TabelaFipeTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            var tabela = new TabelaFipe();

            var resultado = tabela.GetTabelaFipe("carros", "veiculos", "21");

            Assert.IsNotNull(resultado);

        }
    }
}
