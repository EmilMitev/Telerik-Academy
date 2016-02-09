(function () {
    'use strict';

    function LoginController($location, notifier, auth) {
        var vm = this;

        vm.login = function (user, loginForm) {
            if (loginForm.$valid) {
                auth.login(user)
                     .then(function (success) {
                         notifier.success('Successful login!');
                         $location.path('/');
                     }, function (err) {
                         notifier.error('Username/Password combination is not valid!');
                     });
            } else {
                notifier.error('Username and password are required fields!');
            }
        }
    }

    angular.module('ticTacToe.controllers')
        .controller('LoginController', ['$location', 'notifier', 'auth', LoginController]);
}());