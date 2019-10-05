using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

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

        public List<Veiculo> GetVeiculo(string tipoVeiculo, string idMarca, string idVeiculo)
        {
            var requisicaoFipe = WebRequest.CreateHttp(TabelaFipe.URLTabelaFipe + tipoVeiculo + "/veiculo/"
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
    }
}