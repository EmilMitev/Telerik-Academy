(function () {
    'use strict';

    function ProjectsController($location, notifier, projects, identity) {
        var vm = this;

        vm.identity = identity;

        if (identity.isAuthenticated()) {
            vm.request = {
                page: 1
            };

            vm.prevPage = function () {
                if (vm.request.page == 1) {
                    return;
                }

                vm.request.page--;
                vm.filtredProjects();
            }

            vm.nextPage = function () {
                if (!vm.projects || vm.projects.length == 0) {
                    return;
                }

                vm.request.page++;
                vm.filtredProjects();
            }

            vm.filtredProjects = function () {
                projects.allProjects(vm.request)
                    .then(function (filtredProjects) {
                        vm.projects = filtredProjects;
                    });
            }

            projects.allProjects(vm.request)
               .then(function (filtredProjects) {
                   vm.projects = filtredProjects;
               });
        }
        else {
            projects.latestTenProjects()
                .then(function (listedProjects) {
                    vm.projects = listedProjects;
                });
        }
    }

    angular.module('SourceControlSystem.controllers')
        .controller('projectsController', ['$location', 'notifier', 'projects', 'identity', ProjectsController]);
}());