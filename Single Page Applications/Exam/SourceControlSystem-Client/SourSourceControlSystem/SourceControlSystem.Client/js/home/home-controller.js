(function () {
    'use strict';

    function HomeController(projects, commits, statistics) {
        var vm = this;

        projects.latestTenProjects()
                .then(function (listedProjects) {
                    vm.projects = listedProjects;
                });

        commits.latestTenCommits()
               .then(function (listedCommits) {
                   vm.commits = listedCommits;
               });

        statistics.getStats()
            .then(function (stats) {
                vm.stats = stats;
            });
    }

    angular.module('SourceControlSystem.controllers')
        .controller('homeController', ['projects', 'commits', 'statistics', HomeController]);
}());