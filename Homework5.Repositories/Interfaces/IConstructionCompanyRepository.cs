using Homework5.DAL.Domain;
using Homework5.Models.DTO;
using Homework5.Repositories.Interfaces.CRUD;

namespace Homework5.Repositories.Interfaces
{
    /// <summary>
    /// Интерфейс для с объектами Застройщик.
    /// </summary>
   public interface IConstructionCompanyRepository : ICrudRepository<ConstructionCompanyDTO, ConstructionCompany>
    {
    }
}
