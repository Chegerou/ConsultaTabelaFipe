using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace TabelaFipe.Models
{
    public class TabelaFipe
    {
        #region Propriedades
        public int Id { get; set; }
        public int Ano_modelo { get; set; }
        public string Marca { get; set; }
        public string Name { get; set; }
        public string Veiculo { get; set; }
        public string Preco { get; set; }
        public string Combustivel { get; set; }
        public string Referencia { get; set; }
        public string Fipe_codigo { get; set; }
        public string Key { get; set; }
        public string Fipe_name { get; set; }
        
        #endregion

        public List<TabelaFipe> GetTabelaFipe(string tipo, string acao, string parametro)
        {
            var requisicaoFipe = MotarUrlDeRequisicao(tipo, acao, parametro);
            requisicaoFipe.Method = "GET";

            using (var response = requisicaoFipe.GetResponse())
            {
                var streamDados = response.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objctResponse = reader.ReadToEnd();

                var post = JsonConvert.DeserializeObject<List<TabelaFipe>>(objctResponse.ToString());
                                
                return post;
            }
        }
        
        public WebRequest MotarUrlDeRequisicao(string tipo, string acao, string parametro)
        {
            if (String.IsNullOrEmpty(parametro))
            {
                return WebRequest.CreateHttp("http://fipeapi.appspot.com/api/1/" + tipo + "/" + acao +".json");
            }

            return WebRequest.CreateHttp("http://fipeapi.appspot.com/api/1/" + tipo + "/" + acao + "/" + parametro + ".json");
        }









    }
}