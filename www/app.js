angular.module("projetoTabelaFipe", [])
    .controller("FipeCrtl", ["$scope", "VeiculoFactory", function ($scope, VeiculoFactory) {
        $scope.buscarVeiculo = function () {
            $scope.ValidarCamposObrigatorios();
            VeiculoFactory.buscarVeiculo($scope.tipoVeiculo, $scope.nomeDaMarca, $scope.fipeName).then(function (resposta) {
                $scope.dataVeiculos = resposta;
            });
        };

        $scope.VisualizarPrecoMedio = function (TipoVeiculo, NomeDaMarca, FipeName, FipeCodigo) {
            $scope.ValidarCamposObrigatorios();
            VeiculoFactory.buscarVeiculoCompleto(TipoVeiculo, NomeDaMarca, FipeName, FipeCodigo).then(function (resposta) {
                $scope.veiculoCompleto = resposta;
            });
        }

        $scope.ValidarCamposObrigatorios = function () {

            if ($scope.tipoVeiculo == undefined)
                return alert("Você deve preencher o campo Tipo Veiculo.");

            if ($scope.nomeDaMarca == undefined)
                return alert("Você deve preencher o campo Nome da Marca.");

            if ($scope.fipeName == undefined)
                return alert("Você deve preencher o campo Modelo.");
        }


    }])