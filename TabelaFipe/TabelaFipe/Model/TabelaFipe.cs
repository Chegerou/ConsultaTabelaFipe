using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace TabelaFipe
{
    public class TabelaFipe
    {
        #region Propriedades
        public static string URLTabelaFipe = "http://fipeapi.appspot.com/api/1/";
        private string TipoVeiculo { get; set; }
        private string Acao { get; set; }
        private string Parametro { get; set; }
        private int? IdVeiculo { get; set; }
        private int? IdAnoVeiculo { get; set; }
        #endregion

        #region Metodo construtor
        public TabelaFipe(string tipoVeiculo, string acao, string parametro, int? idVeiculo, int? idAnoVeiculo)
        {
            TipoVeiculo = tipoVeiculo;
            Acao = acao;
            Parametro = parametro;
            IdVeiculo = idVeiculo;
            IdAnoVeiculo = idAnoVeiculo;
        }
        #endregion

        public List<Veiculo> GetTabelaFipe()
        {
            var requisicaoFipe = MotarUrlDeRequisicao();
            requisicaoFipe.Method = "GET";

            using (var response = requisicaoFipe.GetResponse())
            {
                var streamDados = response.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objctResponse = reader.ReadToEnd();

                return JsonConvert.DeserializeObject<List<Veiculo>>(objctResponse.ToString());
            }
        }

        public WebRequest MotarUrlDeRequisicao()
        {
            if (String.IsNullOrEmpty(Parametro))
                return WebRequest.CreateHttp(URLTabelaFipe + TipoVeiculo + "/" + Acao + ".json");

            else if (IdVeiculo != 0)
                return WebRequest.CreateHttp(URLTabelaFipe + TipoVeiculo + "/" + Acao + "/" + Parametro + " / " + IdVeiculo + ".json");

            else if (IdAnoVeiculo != 0)
                return WebRequest.CreateHttp(URLTabelaFipe + TipoVeiculo + "/" + Acao + "/" + Parametro + " / " + IdVeiculo + "/" + IdAnoVeiculo + ".json");

            return WebRequest.CreateHttp(URLTabelaFipe + TipoVeiculo + "/" + Acao + "/" + Parametro + ".json");
        }

       





    }
}