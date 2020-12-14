using AutoMapper;
using Homework5.DAL.Domain;
using Homework5.Models.DTO;

namespace Homework5.Repositories.Mapping
{
    /// <summary>
    /// Профиль маппинга (Застройщик).
    /// </summary>
    public class ConstructionCompanyProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ConstructionCompanyProfile"/>
        /// </summary>
        public ConstructionCompanyProfile()
        {
            CreateMap<ConstructionCompany, ConstructionCompanyDTO>().ReverseMap();
        }
    }
}
