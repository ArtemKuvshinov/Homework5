﻿using Homework5.DAL.Domain;
using Homework5.Models.DTO;
using Homework5.Repositories;
using Homework5.Repositories.Interfaces;
using Homework5.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Homework5.Services.Services
{
    public class ConstructionCompanyService : IConstructionCompanyService
    {
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Инициализирует экземпляр <see cref="ConstructionCompanyService"/>.
        /// </summary>
        /// <param name="repository">Репозиторий</param>
        public ConstructionCompanyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        ///<inheritdoc cref="ICreatable{TDto}.Create(TDto)"/>
        public void Create(ConstructionCompanyDTO dto)
        {
            _unitOfWork.BeginTrasaction();
            try
            {
                _unitOfWork.ConstructionCompany.Create(dto);
                _unitOfWork.Save();
                _unitOfWork.CommitTrasaction();
            }
            catch (Exception ex)
            {
                _unitOfWork.RollBackTrasaction();
            }
        }

        /// <inheritdoc cref="IDeletable.Delete(long[])"/>
        public void Delete(params long[] ids)
        {
            _unitOfWork.BeginTrasaction();
            try
            {
                _unitOfWork.ConstructionCompany.Delete(ids);               
                _unitOfWork.Save();
                _unitOfWork.CommitTrasaction();
            }
            catch (Exception ex)
            {
                _unitOfWork.RollBackTrasaction();
            }
        }

        /// <inheritdoc cref="IGettableById{TDto}.Get(long, CancellationToken)"/>
        public ConstructionCompanyDTO Get(long id, CancellationToken token = default)
        {
            return _unitOfWork.ConstructionCompany.Get(id);
        }

        /// <inheritdoc cref="IGettable{TDto}.Get(CancellationToken)"/>
        public IEnumerable<ConstructionCompanyDTO> Get(CancellationToken token = default)
        {
            return _unitOfWork.ConstructionCompany.Get();
        }

        /// <inheritdoc cref="IUpdatable{TDto}.Update(TDto)"/>
        public void Update(ConstructionCompanyDTO dto)
        {
            _unitOfWork.BeginTrasaction();
            try
            {
                _unitOfWork.ConstructionCompany.Update(dto);
                _unitOfWork.Save();
                _unitOfWork.CommitTrasaction();
            }
            catch (Exception ex)
            {
                _unitOfWork.RollBackTrasaction();
            }
        }
    }
}
