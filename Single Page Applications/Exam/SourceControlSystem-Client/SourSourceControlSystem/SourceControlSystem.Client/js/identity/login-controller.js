(function () {
    'use strict';

    function LoginController($location, notifier, identity, auth) {
        var vm = this;

        vm.identity = identity;

        vm.login = function (user, loginForm) {
            if (loginForm.$valid) {
                auth.login(user)
                    .then(function (success) {
                        notifier.success('Successful login!');
                        $location.path('/');
                    }, function (error) {
                        notifier.error('Username/Password combination is not valid!');
                    });
            }
            else {
                notifier.error('Username and password are required fields!')
            }
        }

        vm.logout = function (loginForm) {
            auth.logout().then(function () {
                notifier.success('Successful logout!');
                if (vm.user) {
                    vm.user.email = '';
                    vm.user.username = '';
                    vm.user.password = '';
                }

                loginForm.$setPristine();
                $location.path('/');
            })
        }
    }

    angular.module('SourceControlSystem.controllers')
        .controller('LoginCtrl', ['$location', 'notifier', 'identity', 'auth', LoginController]);
}());