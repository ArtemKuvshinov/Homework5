using Homework5.DAL.Domain;
using Homework5.Models.DTO;
using Homework5.Repositories.Interfaces;
using AutoMapper;
using Homework5.DAL.Contexts;

namespace Homework5.Repositories
{
    /// <summary>
    /// Репозиторий для работы с сущностями Застройщик.
    /// </summary>
    public class ConstructionCompanyRepository : 
        BaseRepository<ConstructionCompanyDTO, ConstructionCompany>, 
        IConstructionCompanyRepository
    {
        public ConstructionCompanyRepository(Homework4Context context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
