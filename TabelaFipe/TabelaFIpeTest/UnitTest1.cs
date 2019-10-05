using Microsoft.VisualStudio.TestTools.UnitTesting;
using TabelaFipe;
using TabelaFipe.Model;

namespace TabelaFipeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var x = new Marca();
            var y = new Veiculo();

            var resposta = x.GetMarca("carros");

            foreach (var res in resposta)
            {
                if (res.Name == "Fiat".ToUpper())
                {
                    y.Id = res.Id;
                    break;
                }
            }

            var teste = y.Id;

        }
    }
}
