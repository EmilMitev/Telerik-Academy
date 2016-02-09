(function () {
    'use strict';

    function RegisterController($location, auth, notifier) {
        var vm = this;

        vm.signup = function (user) {
            auth.signup(user).then(function () {
                notifier.success('Registration successful!');
                $location.path('/');
            })
        }
    }

    angular.module('SourceControlSystem.controllers')
        .controller('SignUpCtrl', ['$location', 'auth', 'notifier', RegisterController]);
}());