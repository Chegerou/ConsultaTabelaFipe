using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabelaFipe.Models;


namespace TabelaFipeTest
{
    [TestClass]
    public class TabelaFipeTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            var tabela = new TabelaFipe.Models.TabelaFipe();

            var resultado = tabela.GetTabelaFipe("carros", "veiculos","21");

            Assert.IsNotNull(resultado);

        }
    }
}
