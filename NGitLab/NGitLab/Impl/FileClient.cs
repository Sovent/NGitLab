using NGitLab.Models;

namespace NGitLab.Impl
{
    public class FileClient : IFilesClient
    {
        private const string FilesUrl = "/files?file_path={0}&ref={1}";
        
        private readonly API _api;
        private readonly string _repoPath;

        public FileClient(API api, string repoPath)
        {
            _api = api;
            _repoPath = repoPath;
        }

        public void Create(FileUpsert file)
        {
            _api.Post().With(file).Stream(_repoPath + "/files", s => { });
        }

        public void Update(FileUpsert file)
        {
            _api.Put().With(file).Stream(_repoPath + "/files", s => { });
        }

        public void Delete(FileDelete file)
        {
            _api.Delete().With(file).Stream(_repoPath + "/files", s => { });
        }

        public FileData Get(FileGet file) {
            return _api.Get().To<FileData>(_repoPath + string.Format(FilesUrl, file.Path, file.Ref));
        }
    }
}