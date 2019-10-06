using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TabelaFipe.Model;

namespace TabelaFipe.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class TabelaFipeController : ControllerBase
    {
        [HttpGet("RetornarVeiculo")]
        public List<Veiculo> RetornarVeiculo(string tipoVeiculo, string nomeDaMarca, string fipeName, string fipeCodigo)
        {
            if (string.IsNullOrWhiteSpace(tipoVeiculo) && string.IsNullOrWhiteSpace(tipoVeiculo) && string.IsNullOrWhiteSpace(tipoVeiculo))
            {
                 throw new Exception("Você deve preencher os campos obrigatorios.");
            }
            return (List<Veiculo>)new Model.TabelaFipe(tipoVeiculo, nomeDaMarca, fipeName).RetornarVeiculo(fipeCodigo);
        }
    }
}