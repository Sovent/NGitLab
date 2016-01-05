using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class ProjectMember
    {
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "username")]
        public string Username;
        [DataMember(Name = "id")]
        public int Id;
        [DataMember(Name = "state")]
        public string State;
        [DataMember(Name = "avatar_url")]
        public string AvatarUrl;
        [DataMember(Name = "web_url")]
        public string WebUrl;
        [DataMember(Name = "access_level")]
        public int AccessLevel;
    }
}