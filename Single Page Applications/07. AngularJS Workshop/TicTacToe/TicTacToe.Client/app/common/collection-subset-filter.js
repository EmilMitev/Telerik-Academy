(function () {
    'use strict';

    function collectionSubset() {
        return function (input, startIndex, endIndex) {
            if (input) {

                return input.slice(+startIndex, endIndex+1);
            }

            return [];
        }
    }

    angular.module('ticTacToe.filters').filter('collectionSubset', [collectionSubset]);
}());