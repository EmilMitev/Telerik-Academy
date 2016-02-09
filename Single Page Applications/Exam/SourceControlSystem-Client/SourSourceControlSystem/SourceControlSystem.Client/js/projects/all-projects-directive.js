(function () {
    'use strict';

    function allProjects() {
        return {
            restrict: 'A',
            templateUrl: 'views/directives/all-projects-directive.html'
        }
    }

    angular.module('SourceControlSystem.directives')
        .directive('allProjects', [allProjects]);
}());