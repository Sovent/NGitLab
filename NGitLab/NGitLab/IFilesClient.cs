using NGitLab.Models;

namespace NGitLab
{
    public interface IFilesClient
    {
        FileData Get(FileGet file);
        void Create(FileUpsert file);
        void Update(FileUpsert file);
        void Delete(FileDelete file);
    }
}