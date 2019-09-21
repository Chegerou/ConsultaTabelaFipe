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

            var tabela = new TabelaFipeProject.TabelaFipe("carros", "marcas", null, 0, 0);

            var resultado = tabela.GetTabelaFipe();

            Assert.IsNotNull(resultado);

        }
    }
}
