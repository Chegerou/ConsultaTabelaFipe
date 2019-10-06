angular.module("TabelaFipe", [])
    .controller("FipeCrtl", ["$scope", function ($scope, VeiculoFactory) {
        $scope.titulo = "Tabela Fipe";
        buscarVeiculo = function () {
            VeiculoFactory.buscarVeiculo($scope.tipoVeiculo, $scope.nomeDaMarca, $scope.fipeName, $scope.fipeCodigo);
        };
    }])