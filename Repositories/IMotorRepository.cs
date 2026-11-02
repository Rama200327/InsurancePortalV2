using InsuraV2.Models;
namespace InsuraV2.Repositories
{
    public interface IMotorRepository
    {
        List<Motor> GetAll();

        Motor GetById(int id);

        void Add(Motor motor);

        void Update(Motor motor);

        void Delete(int id);
    }
}