using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TabelaFipe.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class TabelaFipeController : ControllerBase
    {
        [HttpGet("RetornarVeiculo")]
        public object RetornarVeiculo(string tipoVeiculo, string acao, string parametro, int? idVeiculo, int? idAnoVeiculo)
        {
            var tabela = new TabelaFipe(tipoVeiculo,acao,parametro,idVeiculo,idAnoVeiculo);

            return tabela.GetTabelaFipe();
        }
    }
}