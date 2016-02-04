using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class ProjectMembershipCreateRequest
    {
        [Required]
        [DataMember(Name = "id")]
        public int ProjectId { get; set; }

        [Required]
        [DataMember(Name = "user_id")]
        public int UserId { get; set; }

        [Required]
        [DataMember(Name = "access_level")]
        public int AccessLevel { get; set; }
    }
}