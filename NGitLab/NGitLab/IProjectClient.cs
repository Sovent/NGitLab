using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab
{
    public interface IProjectClient
    {
        /// <summary>
        /// Get a list of projects accessible by the authenticated user.
        /// </summary>
        IEnumerable<Project> Accessible { get; }

        /// <summary>
        /// Get a list of projects owned by the authenticated user.
        /// </summary>
        IEnumerable<Project> Owned { get; }

        /// <summary>
        /// Get a list of all GitLab projects (admin only).
        /// </summary>
        IEnumerable<Project> All { get; }

        /// <summary>
        /// Get a project by its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Project this[int id] { get; }

        /// <summary>
        /// Return a list of projects matching <paramref name="name"/>
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        IEnumerable<Project>this[string name] { get; }

        Project Create(ProjectCreate project);

        Project Update(ProjectUpdate project);

        bool Delete(int id);
    }
}