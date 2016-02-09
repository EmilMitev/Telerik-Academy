(function () {
    'use strict';

    function CommitDetailsController($location, $routeParams, commits, notifier, projects, identity) {
        var vm = this;

        vm.identity = identity;

        if (identity.isAuthenticated()) {
            var id = $routeParams.id;
           
            commits.commitDetails(id)
                .then(function (details) {
                    vm.details = details;
                });

        }
    }

    angular.module('SourceControlSystem.controllers')
        .controller('commitDetailsController', ['$location', '$routeParams', 'commits', 'notifier', 'projects', 'identity', CommitDetailsController]);
}());