(function () {
    'use strict';

    function RegisterController($location, notifier, auth) {
        var vm = this;

        vm.register = function (user, registerForm) {
            if (registerForm.$valid) {
                auth.register(user)
                     .then(function () {
                         notifier.success(user.username + ' successfully registered!');
                         auth.login({ username: user.username, password: user.password })
                                 .then(function () {
                                     $location.path('/');
                                 });
                     }, function () {
                         notifier.error('There was a problem with the registration of ' + user.username + '!');
                     });
            } else {
                notifier.error('All fields are required!');
            }
        }
    }

    angular.module('ticTacToe.controllers')
        .controller('RegisterController', ['$location', 'notifier', 'auth', RegisterController]);
}());