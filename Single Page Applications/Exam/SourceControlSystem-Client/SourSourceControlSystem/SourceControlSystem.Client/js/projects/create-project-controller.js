(function () {
    'use strict';

    function CreateProjectController($location, notifier, projects, identity) {
        var vm = this;

        vm.identity = identity;

        vm.createProject = function createProject(newProject) {

            projects.createProject(newProject)
                .then(function (response) {
                    notifier.success('Project successfully created.');
                    vm.projectId = response;
                    $location.path('/projects');
                }, function (err) {
                    notifier.error('Project cannot be created. Please try again later!');
                });
        }
    }

    angular.module('SourceControlSystem.controllers')
        .controller('createProjectController', ['$location', 'notifier', 'projects', 'identity', CreateProjectController]);
}());