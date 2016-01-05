using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class FileGet
    {
        [Required]
        [DataMember(Name="file_path")]
        public string Path; 
        
        [Required]
        [DataMember(Name="ref")]
        public string Ref;
    }
}