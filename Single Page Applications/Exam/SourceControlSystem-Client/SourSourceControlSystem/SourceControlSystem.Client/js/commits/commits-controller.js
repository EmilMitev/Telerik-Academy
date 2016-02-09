(function () {
    'use strict';

    function CommitsController($location, notifier, commits, identity) {
        var vm = this;

        vm.identity = identity;

        if (identity.isAuthenticated()) {


            commits.latestTenCommits()
                .then(function (listedCommits) {
                    vm.commits = listedCommits;
                });

        }
        else {
            $location.path('/unauthorized');
        }
    }

    angular.module('SourceControlSystem.controllers')
        .controller('commitsController', ['$location', 'notifier', 'commits', 'identity', CommitsController]);
}());