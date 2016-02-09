(function () {
    'use strict';

    function CreateCommitController($location, $routeParams, notifier, commits, identity) {
        var vm = this;

        vm.identity = identity;
        var id = $routeParams.id;

        vm.createCommit = function createCommit(newCommit) {
            newCommit.projectId = id;
            console.log(newCommit)
            commits.createCommit(newCommit)
                .then(function (response) {
                    notifier.success('Commit successfully created.');
                    vm.projectId = response;
                    $location.path('/projects/' + id);
                }, function (err) {
                    notifier.error('Commit cannot be created. Please try again later!');
                });
        }
    }

    angular.module('SourceControlSystem.controllers')
        .controller('createCommitController', ['$location','$routeParams', 'notifier', 'commits', 'identity', CreateCommitController]);
}());