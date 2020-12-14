using AutoMapper;
using Homework5.Models.DTO;
using Homework5.Models.Requests.ConstructionCompany;
using Homework5.Models.Responses.ConstructionCompany;

namespace Homework5.Controllers.Mapping
{
    /// <summary>
    /// Маппинг для запросов и ответов контроллера сущности "Застройщик".
    /// </summary>
    public class ConstructionCompanyProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="ConstructionCompanyProfile"/>.
        /// </summary>
        public ConstructionCompanyProfile()
        {
            CreateMap<CreateConstructionCompanyRequest, ConstructionCompanyDTO>();
            CreateMap<UpdateConstructionCompanyRequest, ConstructionCompanyDTO>();
            CreateMap<ConstructionCompanyDTO, ConstructionCompanyResponse>();
        }
    }
}
