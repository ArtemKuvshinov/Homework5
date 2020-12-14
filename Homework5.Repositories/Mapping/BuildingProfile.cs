using AutoMapper;
using Homework5.DAL.Domain;
using Homework5.Models.DTO;

namespace Homework5.Services.Mapping
{
    /// <summary>
    /// Профиль маппинга (здание).
    /// </summary>
    public class BuildingProfile : Profile
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="BuildingProfile"/>
        /// </summary>
        public BuildingProfile()
        {
            CreateMap<Building, BuildingDTO>().ReverseMap();
        }
    }
}
