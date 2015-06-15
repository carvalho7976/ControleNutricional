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
ControleNutricional.factory('Grupo', function ($resource) {
    return $resource('/api/grupo/:id', { Id: '@id' }, { update: { method: 'PUT' } });
});
ControleNutricional.factory('AlimentoRefeicao', function ($resource) {
    return $resource('/api/alimentorefeicao/:id', { Id: '@id' }, { update: { method: 'PUT' } });
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
var CadastroAlimentoControl = function ($scope, $location, $routeParams, ControleNutricional, Grupo) {
    //pegar grupos de alimentos do banco
    //receber os parametros do form e salvar
    $scope.grupoArray = [];
    var lista;
    $scope.search = function () {
        Grupo.query({},
            function (data) {
                $scope.grupoArray = data;
                $scope.grupo = $scope.grupoArray[0];
            });
    };
    $scope.search();
    
    $scope.save = function () {
        $scope.alimento.Grupo = $scope.grupo.Id;

        console.log($scope.alimento);
        ControleNutricional.save($scope.alimento, function () {
           $location.path('/');
        });
    };
};

var CadastroRefeicaoControl = function ($scope, $location, $routeParams, ControleNutricional, AlimentoRefeicao) {
    var alimentos = [];
   // $scope.allStates = [];
    var estados = [];
    $scope.allState = [];
    $scope.search = function () {
        ControleNutricional.query({},
            function (data) {
                console.log("adicionar estados");
                $scope.allStates = data;
                console.log($scope.allStates);
                console.log("--------------")
                //$scope.stateSelected = $scope.allStates[0].Nome;
            });
    };
       
   $scope.addItem = function () {
        var alimento = $scope.stateSelected.Nome;
        if (alimento != null && alimento != '') {
            var myEl = angular.element(document.querySelector('#divAlimentos'));
            myEl.append("<br/> " + alimento);
            alimentos.push($scope.stateSelected);
        }
    };
   $scope.saveRefeicao = function () {
       //implementar       
    };

    $scope.getAllStates = function (callback) {
        callback($scope.allStates);
    };
    //$scope.allStates
    $scope.stateSelected = function (state) {
        $scope.stateInfo = state.name + " (" + state.id + ")";
    };
    $scope.search();
    console.log(estados);
    //$scope.allStates = estados;
   
};
