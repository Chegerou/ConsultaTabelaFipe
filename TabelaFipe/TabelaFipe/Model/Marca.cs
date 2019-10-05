using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace TabelaFipe.Model
{
    public class Marca
    {
        #region Propriedades
        public string Key { get; set; }
        public string Id { get; set; }
        public string Fipe_name { get; set; }
        public string Name { get; set; } 
        #endregion

        public List<Marca> GetMarca(string tipoVeiculo)
        {
            var requisicaoFipe = WebRequest.CreateHttp(TabelaFipe.URLTabelaFipe + tipoVeiculo + "/marcas.json");
            requisicaoFipe.Method = "GET";

            using (var response = requisicaoFipe.GetResponse())
            {
                var streamDados = response.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objctResponse = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<List<Marca>>(objctResponse.ToString());
            }
        }

    }
}
