using System.Collections;
using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class Compare
    {
        [DataMember(Name = "commit")]
        public Commit Commit;

        [DataMember(Name = "commits")]
        public Commit[] Commits;

        [DataMember(Name = "diffs")]
        public Diff[] Diffs;

        [DataMember(Name = "compare_timeout")]
        public bool IsTimeout;

        [DataMember(Name = "compare_same_ref")]
        public bool IsSameRef;
    }
}