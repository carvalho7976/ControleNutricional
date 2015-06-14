var ControleNutricional = angular.module("ControleNutricional", ['ngRoute', 'ngResource', 'acute.select']).
    config(function ($routeProvider) {
        $routeProvider.
            when('/', { controller: IndexControl, templateUrl: '/pages/home.html' }).
            when('/cadastrar', { controller: CadastroAlimentoControl, templateUrl: '/pages/cadastrarAlimento.html' }).
            when('/cadastrarRefeicao', { controller: CadastroRefeicaoControl, templateUrl: '/pages/cadastrarRefeicao.html' }).

            otherwise({ redirectTo: '/' });
    });

ControleNutricional.factory('ControleNutricional', function ($resource) {
    return $resource('/api/alimento/:id', { Id: '@id' }, { update: { method: 'PUT' } });
});

var IndexControl = function ($scope, $location, $routeParams, ControleNutricional) {
    $scope.message = "Fulano";
    $scope.listarTodos = function () {
        ControleNutricional.query({
        },
           function (data) {
               console.log(data);
           });

    };

};
var CadastroAlimentoControl = function ($scope, $location, $routeParams, ControleNutricional) {
    //pegar grupos de alimentos do banco
    //receber os parametros do form e salvar
    $scope.save = function () {
        console.log("entrou salvar");
        ControleNutricional.save($scope.alimento, function () {
            $location.path('/');
        });
    };
};

var CadastroRefeicaoControl = function ($scope, $location, $routeParams, ControleNutricional) {
    var alimentos = [];
    $scope.addItem = function () {
        var alimento = $scope.stateSelected.name;
        if (alimento != null && alimento != '') {
            var myEl = angular.element(document.querySelector('#divAlimentos'));
            myEl.append("<br/> " + alimento);
            alimentos.push($scope.stateSelected);
        }
    };
    $scope.saveRefeicao = function () {
        console.log(alimentos);
    };

    $scope.getAllStates = function (callback) {
        callback($scope.allStates);
    };

    $scope.stateSelected = function (state) {
        $scope.stateInfo = state.name + " (" + state.id + ")";
    };


    console.log("cliquei adicionar");
    $scope.allStates = [{ "name": "Alabama", "id": "AL" }, { "name": "Alaska", "id": "AK" }, { "name": "Abasdfa", "id": "Ac" }];
};
