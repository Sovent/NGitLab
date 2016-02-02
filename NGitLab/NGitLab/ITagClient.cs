using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab
{
    public interface ITagClient
    {
        IEnumerable<Tag> All { get; }

        Tag Create(TagCreate tag);
    }
}