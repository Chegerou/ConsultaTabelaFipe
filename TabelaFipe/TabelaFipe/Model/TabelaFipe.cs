using System;
using System.Collections.Generic;

namespace TabelaFipe.Model
{
    public class TabelaFipe
    {
        #region Propriedades
        public static string URLTabelaFipe = "http://fipeapi.appspot.com/api/1/";
        private string TipoVeiculo { get; set; }
        private string IdMarca { get; set; }
        private string IdVeiculo { get; set; }
        public string NomeDaMarca { get; set; }
        public string FipeName { get; set; }
        #endregion

        #region Metodo construtor
        public TabelaFipe(string tipoVeiculo, string nomeDaMarca, string fipeName)
        {
            TipoVeiculo = tipoVeiculo;
            NomeDaMarca = nomeDaMarca;
            FipeName = fipeName;
        }
        #endregion

        public List<Veiculo> RetornarVeiculo()
        {
            this.BuscarIdMarca();
            this.BuscarIdVeiculo();
            return new Veiculo().GetVeiculos(TipoVeiculo, IdMarca, IdVeiculo);
        }

        public Veiculo RetornarVeiculoCompleto(string fipeCodigo)
        {
            this.BuscarIdMarca();
            this.BuscarIdVeiculo();
            return new Veiculo().GetVeiculoCompleto(TipoVeiculo, IdMarca, IdVeiculo,fipeCodigo);
        }
        
        public void BuscarIdMarca()
        {
            var marcas = new Marca().GetMarca(TipoVeiculo);
            if (marcas != null)
            {
                foreach (var marca in marcas)
                {
                    if (NomeDaMarca.ToUpper() == marca.Name.ToUpper())
                    {
                        IdMarca = marca.Id;
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("A marca procurada não existe.");
            }
        }

        public void BuscarIdVeiculo()
        {
            var veiculos = new Veiculos().GetVeiculos(TipoVeiculo, IdMarca);
            if (veiculos != null)
            {
                foreach (var veiculo in veiculos)
                {
                    if (veiculo.Fipe_name.ToUpper().Contains(FipeName.ToUpper()))
                    {
                        IdVeiculo = veiculo.Id;
                        break;
                    }
                }
            }
            else
            {
                throw new Exception("O veiculo procurada não existe.");
            }
        }
    }
}
