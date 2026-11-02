using InsuraV2.Models;

namespace InsuraV2.Repositories
{
    public interface IMedicalRepository
    {
        List<Medical> GetAll();

        Medical GetById(int id);

        void Add(Medical medical);

        void Update(Medical medical);

        void Delete(int id);
    }
}