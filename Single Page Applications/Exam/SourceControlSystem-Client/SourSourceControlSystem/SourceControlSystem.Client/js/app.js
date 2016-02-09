(function () {
    'use strict';

    function config($routeProvider) {
        $routeProvider
            .when('/', {
                templateUrl: 'views/partials/home.html',
                controller: 'homeController',
                controllerAs: 'vm'
            })
            .when('/unauthorized', {
                template: '<h1 class="text-center">YOU ARE NOT AUTHORIZED!</h1>'
            })
            .when('/register', {
                templateUrl: 'views/partials/register.html',
                controller: 'SignUpCtrl',
                controllerAs: 'vm'
            })
            .when('/projects', {
                templateUrl: 'views/partials/projects.html',
                controller: 'projectsController',
                controllerAs: 'vm'
            })
            .when('/projects/add', {
                templateUrl: 'views/partials/create-project.html',
                controller: 'createProjectController',
                controllerAs: 'vm'
            })
            .when('/projects/:id', {
                templateUrl: 'views/partials/project-details.html',
                controller: 'projectDetailController',
                controllerAs: 'vm'
            })
            .when('/projects/:id/addcommits', {
                templateUrl: 'views/partials/create-commit.html',
                controller: 'createCommitController',
                controllerAs: 'vm'
            })
            .when('/commits', {
                templateUrl: 'views/partials/commits.html',
                controller: 'commitsController',
                controllerAs: 'vm'
            })
            .when('/commits/:id', {
                templateUrl: 'views/partials/commit-details.html',
                controller: 'commitDetailsController',
                controllerAs: 'vm'
            })

            .otherwise({ redirectTo: '/' });
    }

    angular.module('SourceControlSystem.filters', []);
    angular.module('SourceControlSystem.directives', []);
    angular.module('SourceControlSystem.services', []);
    angular.module('SourceControlSystem.controllers', ['SourceControlSystem.services']);

    angular.module('SourceControlSystem', ['ngRoute', 'ngCookies', 'kendo.directives', 'SourceControlSystem.controllers', 'SourceControlSystem.directives', 'SourceControlSystem.filters']).
        config(['$routeProvider', config])
        .value('toastr', toastr)
        .constant('baseServiceUrl', 'http://spa.bgcoder.com');
}());