(function () {
    'use strict';

    function ProjectDetailsController($location, $routeParams, commits, notifier, projects, identity) {
        var vm = this;

        vm.identity = identity;
        if (identity.isAuthenticated()) {
            var id = $routeParams.id;
            vm.projId = id;
            projects.projectsDetails(id)
                .then(function (details) {
                    vm.name = details.Name;
                    vm.date = details.CreatedOn;
                });

            projects.allCollaboratorPerProject(id)
                .then(function (collaborators) {
                    vm.collaborators = collaborators;
                });

            commits.allCommitsPerProject(id)
                .then(function (commits) {
                    vm.commits = commits;
                });

        }
    }

    angular.module('SourceControlSystem.controllers')
        .controller('projectDetailController', ['$location', '$routeParams', 'commits', 'notifier', 'projects', 'identity', ProjectDetailsController]);
}());