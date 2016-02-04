using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab.Impl
{
    public class ProjectMembersClient : IProjectMembersClient
    {
        public ProjectMembersClient(API api)
        {
            _api = api;
        }

        public IEnumerable<ProjectMember> GetMembers(int projectId)
        {
            return _api.Get().GetAll<ProjectMember>(GetRequestUrl(projectId));
        }

        public void AddProjectMember(ProjectMembershipCreateRequest request)
        {
            _api.Post().With(request).Stream(GetRequestUrl(request.ProjectId), s => { });
        }

        public void DeleteProjectMember(RemoveProjectMembershipRequest request)
        {
            _api.Delete().With(request).Stream(GetRequestUrl(request.ProjectId), s => { });
        }

        private string GetRequestUrl(int projectId)
        {
            return string.Format(MembersUrl, projectId);
        }

        private readonly API _api;

        private const string MembersUrl = "/projects/{0}/members";
    }
}