angular.module("projetoTabelaFipe", [])
    .controller("FipeCrtl", ["$scope", "VeiculoFactory", function ($scope, VeiculoFactory) {
        $scope.titulo = "Tabela Fipe";

        $scope.buscarVeiculo = function () {
            $scope.ValidarCamposObrigatorios();
            VeiculoFactory.buscarVeiculo($scope.tipoVeiculo, $scope.nomeDaMarca, $scope.fipeName, $scope.fipeCodigo).then(function (resposta) {
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
                $scope.tipoVeiculo = "";

            if ($scope.nomeDaMarca == undefined)
                $scope.nomeDaMarca = "";

            if ($scope.fipeName == undefined)
                $scope.fipeName = "";

            if ($scope.fipeCodigo == undefined)
                $scope.fipeCodigo = "";
        }


    }])