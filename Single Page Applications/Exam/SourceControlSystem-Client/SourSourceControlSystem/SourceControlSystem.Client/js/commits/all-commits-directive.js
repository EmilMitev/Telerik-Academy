(function () {
    'use strict';

    function AllCommits() {
        return {
            restrict: 'A',
            templateUrl: 'views/directives/all-commits-directive.html'
        }
    }

    angular.module('SourceControlSystem.directives')
        .directive('allCommits', [AllCommits]);
}());