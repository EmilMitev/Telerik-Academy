(function () {
    'use strict';

    function CommitsService($q, $http, baseServiceUrl, data) {

        function latestTenCommits() {
            return data.get('api/commits');
        }

        function commitDetails(commitId) {
            return data.get('api/commits/' + commitId);
        }

        function allCommitsPerProject(projectId) {
            return data.get('api/commits/byproject/' + projectId);
        }

        function createCommit(commit) {
            return data.post('api/commits', commit);
        }

        //function allProjects(queryParams) {
        //    return data.get('api/projects/all', queryParams);
        //}

       

        //function addProjectCollaborator(projectId) {
        //    return data.put('api/projects/' + projectId);
        //}


        

        return {
            latestTenCommits: latestTenCommits,
            allCommitsPerProject: allCommitsPerProject,
            createCommit: createCommit,
            commitDetails: commitDetails,
            //projectsDetails: projectsDetails,
            //addProjectCollaborator: addProjectCollaborator,
            //allCollaboratorPerProject: allCollaboratorPerProject
        }
    }

    angular.module('SourceControlSystem.services')
        .factory('commits', ['$q', '$http', 'baseServiceUrl', 'data', CommitsService]);
}());