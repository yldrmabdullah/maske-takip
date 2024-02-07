using Entities.Concrete;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        bool CheckPerson(Person person);
    }
}
