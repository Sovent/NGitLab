using System.Collections.Generic;
using NGitLab.Models;

namespace NGitLab.Impl
{
    public class TagClient : ITagClient
    {
        private const string TagsUrl = "{0}/tags";

        private readonly API _api;
        private readonly string _repoPath;

        public TagClient(API api, string repoPath)
        {
            _api = api;
            _repoPath = repoPath;
        }

        public IEnumerable<Tag> All {
            get { return _api.Get().GetAll<Tag>(_repoPath + "/tags"); }
        }


        public Tag Create(TagCreate tag) {
            return _api.Post().With(tag).To<Tag>(string.Format(TagsUrl, _repoPath));
        }
    }
}
