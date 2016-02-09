(function () {
    'use strict';

    function projectsService($q, $http, baseServiceUrl, data) {

        function latestTenProjects() {
            return data.get('api/projects');
        }

        function createProject(project) {
            return data.post('api/projects', project);
        }

        function allProjects(queryParams) {
            return data.get('api/projects/all', queryParams);
        }

        function projectsDetails(projectId) {
            return data.get('api/projects/' + projectId);
        }

        function allCollaboratorPerProject(projectId) {
            return data.get('api/projects/collaborators/' + projectId);
        }

       
        //function addProjectCollaborator(projectId) {
        //    return data.put('api/projects/' + projectId);
        //}



        return {
            latestTenProjects: latestTenProjects,
            createProject: createProject,
            allProjects: allProjects,
            projectsDetails: projectsDetails,
            allCollaboratorPerProject: allCollaboratorPerProject,
            //addProjectCollaborator: addProjectCollaborator,
        }
    }

    angular.module('SourceControlSystem.services')
        .factory('projects', ['$q', '$http', 'baseServiceUrl', 'data', projectsService]);
}());