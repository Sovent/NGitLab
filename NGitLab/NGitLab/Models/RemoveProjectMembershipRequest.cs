using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models
{
    public class RemoveProjectMembershipRequest
    {
        [Required]
        [DataMember(Name = "id")]
        public int ProjectId { get; set; }

        [Required]
        [DataMember(Name = "user_id")]
        public int UserId { get; set; }
    }
}