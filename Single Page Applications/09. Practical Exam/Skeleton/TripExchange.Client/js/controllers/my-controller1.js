(function () {
    'use strict';

    function MyCtrl1($scope, notifier) {
       
    }

    angular.module('myApp.controllers')
        .controller('MyCtrl1', ['$scope', 'notifier', MyCtrl1]);
}());