using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab
{
    public interface IProjectMembersClient
    {
        IEnumerable<ProjectMember> GetMembers(int projectId);

        void AddProjectMember(ProjectMembershipCreateRequest request);

        void DeleteProjectMember(RemoveProjectMembershipRequest request);
    }
}