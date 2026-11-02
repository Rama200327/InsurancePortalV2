using InsuraV2.Models;

namespace InsuraV2.Repositories
{
    public interface ITravelRepository
    {
        List<Travel> GetAll();

        Travel GetById(int id);

        void Add(Travel travel);

        void Update(Travel travel);

        void Delete(int id);
    }
}