using Microsoft.AspNetCore.Mvc;

namespace TabelaFipe.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class TabelaFipeController : ControllerBase
    {
        [HttpGet("RetornarVeiculo")]
        public object RetornarVeiculo(string tipoVeiculo, string nomeDaMarca, string fipeName, string fipeCodigo)
        {
            return new Model.TabelaFipe(tipoVeiculo, nomeDaMarca, fipeName).RetornarVeiculo(fipeCodigo);
        }
    }
}