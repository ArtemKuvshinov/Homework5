using System.Collections.Generic;
using Homework5.Models.DTO;
using Homework5.DAL.Domain;

namespace Homework5.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для сервиса "Здание".
    /// </summary>
    public interface IBuildingService : ICrudService<BuildingDTO>
    {
    }
}
