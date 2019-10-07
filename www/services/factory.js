angular.module("projetoTabelaFipe")
    .factory("VeiculoFactory", function ($q, $http) {
        return {
            buscarVeiculo: function (tipoVeiculo, nomeDaMarca, fipeName, fipeCodigo) {
                var promessa = $q.defer();
                var url = "https://localhost:44375/api/TabelaFipe/RetornarVeiculo?tipoVeiculo=" + tipoVeiculo
                    + "&nomeDaMarca=" + nomeDaMarca + "&fipeName=" + fipeName + "&fipeCodigo=" + fipeCodigo;

                $http.get(url).then(
                    function (sucess) {
                        promessa.resolve(sucess.data);
                        console.log(sucess);
                    },
                    function (error) {
                        console.log(erro);
                    }
                );
                return promessa.promise;
            },
            buscarVeiculoCompleto: function (tipoVeiculo, nomeDaMarca, fipeName, fipeCodigo) {
                var promessa = $q.defer();
                var url = "https://localhost:44375/api/TabelaFipe/RetornarVeiculoCompleto?tipoVeiculo=" + tipoVeiculo
                    + "&nomeDaMarca=" + nomeDaMarca + "&fipeName=" + fipeName + "&fipeCodigo=" + fipeCodigo;

                $http.get(url).then(
                    function (sucess) {
                        promessa.resolve(sucess.data);
                        console.log(sucess);
                    },
                    function (error) {
                        console.log(erro);
                    }
                );
                return promessa.promise;
            }
        };
    })
