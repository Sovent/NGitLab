using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class TagCreate
    {
        [Required]
        [DataMember(Name = "tag_name")]
        public string Name;

        [Required]
        [DataMember(Name = "ref")]
        public string Ref;

		[DataMember(Name = "message")]
		public string Message;
    }
}