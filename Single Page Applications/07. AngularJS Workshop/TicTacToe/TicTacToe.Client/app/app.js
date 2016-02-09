﻿(function () {
    'use strict';

    function config($routeProvider, $locationProvider) {

        var CONTROLLER_VIEW_MODEL_NAME = 'vm';

        $locationProvider.html5Mode(true);

        var routeResolvers = {
            authenticationRequired: {
                authenticate: ['$q', 'auth', function ($q, auth) {
                    if (auth.isAuthenticated()) {
                        return true;
                    }

                    return $q.reject('not authorized');
                }]
            }
        }

        $routeProvider
            .when('/', {
                templateUrl: 'partials/home/home.html',
                controller: 'MainController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/identity/register', {
                templateUrl: 'partials/identity/register.html',
                controller: 'RegisterController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
            .when('/identity/login', {
                templateUrl: 'partials/identity/login.html',
                controller: 'LoginController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME
            })
             .when('/games', {
                 templateUrl: 'partials/games/listed-games.html',
                 controller: 'ListedGameController',
                 controllerAs: CONTROLLER_VIEW_MODEL_NAME,
             })
            .when('/games/:gameId', {
                templateUrl: 'partials/games/play-game.html',
                controller: 'PlayGameController',
                controllerAs: CONTROLLER_VIEW_MODEL_NAME,
                resolve: routeResolvers.authenticationRequired
                
            })
            .otherwise({ redirectTo: '/' });
    }

    function run($http, $cookies, $rootScope, $location, auth) {
        $rootScope.$on('$routeChangeError', function (ev, current, previous, rejection) {
            if (rejection === 'not authorized') {
                $location.path('/');
            }
        });

        if (auth.isAuthenticated()) {
            $http.defaults.headers.common.Authorization = 'Bearer ' + $cookies.get('authentication');
            auth.getIdentity();
        }
    };

    angular.module('ticTacToe.filters', []);
    angular.module('ticTacToe.services', []);
    angular.module('ticTacToe.directives', []);
    angular.module('ticTacToe.controllers', ['ticTacToe.services']);

    angular.module('ticTacToe', ['ngRoute', 'ngCookies', 'ticTacToe.controllers', 'ticTacToe.directives', 'ticTacToe.filters'])
        .config(['$routeProvider', '$locationProvider', config])
        .run(['$http', '$cookies', '$rootScope', '$location', 'auth', run])
        .value('toastr', toastr)
        .constant('baseUrl', 'http://localhost:33257/');
}());