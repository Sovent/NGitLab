using System;
using System.Collections.Generic;
using System.IO;
using NGitLab.Models;

namespace NGitLab
{
    public interface IRepositoryClient
    {
        ITagClient Tags { get; }
        IEnumerable<TreeOrBlob> Tree { get; }
        void GetRawBlob(string sha, Action<Stream> parser);
        
        IEnumerable<Commit> Commits { get; }
        SingleCommit GetCommit(Sha1 sha);
        IEnumerable<Diff> GetCommitDiff(Sha1 sha);
        Compare Compare(Sha1 from, Sha1 to);

        IFilesClient Files { get; }

        IBranchClient Branches { get; }

        IProjectHooksClient ProjectHooks { get; }
    }
}