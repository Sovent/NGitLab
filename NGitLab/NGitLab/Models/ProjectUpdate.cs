using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class ProjectUpdate
    {
        [Required]
        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "path")]
        public string Path;

        [DataMember(Name = "description")]
        public string Description;

        [DataMember(Name = "default_branch")]
        public string DefaultBranchName;

        [DataMember(Name = "issues_enabled")]
        public bool IssuesEnabled;

        [DataMember(Name = "merge_requests_enabled")]
        public bool MergeRequestsEnabled;

        [DataMember(Name = "builds_enabled")]
        public bool BuildsEnabled;

        [DataMember(Name = "snippets_enabled")]
        public bool SnippetsEnabled;

        [DataMember(Name = "wiki_enabled")]
        public bool WikiEnabled;

        [DataMember(Name = "public")]
        public bool Public;

        [DataMember(Name = "import_url")]
        public string ImportUrl;

        [DataMember(Name = "visibility_level")]
        public VisibilityLevel VisibilityLevel;

        [DataMember(Name = "public_builds")]
        public bool PulicBuilds;
    }
}