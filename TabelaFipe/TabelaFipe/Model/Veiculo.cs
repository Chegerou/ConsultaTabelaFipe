using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace TabelaFipe.Model
{
    public class Veiculo
    {
        #region Propriedades
        public string Id { get; set; }
        public string Ano_modelo { get; set; }
        public string Marca { get; set; }
        public string Name { get; set; }
        public string veiculo { get; set; }
        public string Preco { get; set; }
        public string Combustivel { get; set; }
        public string Referencia { get; set; }
        public string Fipe_codigo { get; set; }
        public string Key { get; set; }
        public string Fipe_name { get; set; }
        #endregion

        public List<Veiculo> GetVeiculos(string tipoVeiculo, string idMarca, string idVeiculo)
        {
            WebRequest requisicaoFipe;

            requisicaoFipe = WebRequest.CreateHttp(TabelaFipe.URLTabelaFipe + tipoVeiculo + "/veiculo/"
                                                       + idMarca + "/" + idVeiculo + ".json");
            requisicaoFipe.Method = "GET";

            using (var response = requisicaoFipe.GetResponse())
            {
                var streamDados = response.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objctResponse = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<List<Veiculo>>(objctResponse.ToString());
            }
        }

        public Veiculo GetVeiculoCompleto(string tipoVeiculo, string idMarca, string idVeiculo, string fipeCodigo)
        {
            WebRequest requisicaoFipe;
            requisicaoFipe = WebRequest.CreateHttp(TabelaFipe.URLTabelaFipe + tipoVeiculo + "/veiculo/"
                                                    + idMarca + "/" + idVeiculo + "/" + fipeCodigo + ".json");

            requisicaoFipe.Method = "GET";

            using (var response = requisicaoFipe.GetResponse())
            {
                var streamDados = response.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objctResponse = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<Veiculo>(objctResponse.ToString());
            }
        }
    }
}