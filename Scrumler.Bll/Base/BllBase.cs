using AutoMapper;
using Scrumler.Dal.Abstract;
using Scrumler.Entity.Base;
using Scrumler.Interface.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scrumler.Bll.Base
{
    public class BllBase<T, TDto> : IBllBase<T, TDto> where T : EntityBase where TDto : DtoBase
    {
        #region Variables

        public readonly IUnitofWork _uow;
        public readonly IServiceProvider _service;
        public readonly IGenericRepository<T> _repository;

        #endregion Variables

        public BllBase(IServiceProvider service)
        {
            _uow = service.GetService<IUnitofWork>();
            _repository = _uow.GetRepository<T>();
            _service = service;
        }

        public virtual IBllResponse<TDto> Find(int id)
        {
            try
            {
                //Geriye Mapper ile mapleyerek dto dönüyoruz T bizim entitylerimiz için generic type ve TDto ise dto larımız için generic type görevi görüyor.
                return new BllResponse<TDto>
                {
                    Message = "Success",
                    StatusCode = StatusCodes.Status200OK,
                    Data = Mapper.Map<T, TDto>(_repository.Find(id))
                };
            }
            catch (Exception ex)
            {
                return new BllResponse<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public virtual IBllResponse<List<TDto>> GetAll()
        {
            try
            {
                List<T> entities = _repository.GetAll().ToList();
                var a = new BllResponse<List<TDto>>
                {
                    Message = "Success",
                    StatusCode = StatusCodes.Status200OK,
                    Data = entities.Select(x => Mapper.Map<TDto>(x)).ToList()
                };

                return a;
            }
            catch (Exception ex)
            {
                return new BllResponse<List<TDto>>
                {
                    Message = $"Error:{ex.Message}",
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Data = null
                };
            }
        }

        public virtual IQueryable<T> GetQueryable()
        {
            try
            {
                return _repository.GetAll();
            }
            catch
            {
                return null;
            }
        }

        public virtual IBllResponse<string> DeleteById(int id, bool saveChanges = true)
        {
            try
            {
                _repository.Delete(id);
                if (saveChanges) { Save(); }
                return new BllResponse<string>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = null
                };
            }
            catch (Exception ex)
            {
                return new BllResponse<string>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public virtual async Task<IBllResponse<string>> DeleteByIdAsync(int id, bool saveChanges = true)
        {
            return DeleteById(id, saveChanges);
        }

        public virtual IBllResponse<string> Delete(TDto item, bool saveChanges = true)
        {
            var resolvedItem = String.Join(',', item.GetType().GetProperties().Select(x => $" - {x.Name} : {x.GetValue(item)} - ").ToList());
            try
            {
                _repository.Delete(Mapper.Map<T>(item));
                if (saveChanges) { Save(); }
                return new BllResponse<string>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = null
                };
            }
            catch (Exception ex)
            {
                return new BllResponse<string>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public virtual async Task<IBllResponse<string>> DeleteAsync(TDto item, bool saveChanges = true)
        {
            return Delete(item, saveChanges);
        }

        public virtual IBllResponse<TDto> Add(TDto item, bool saveChanges = true)
        {
            var resolvedResult = "";
            try
            {
                var TResult = _repository.Add(Mapper.Map<T>(item));
                if (saveChanges) { Save(); }
                resolvedResult = String.Join(',', TResult.GetType().GetProperties().Select(x => $" - {x.Name} : {x.GetValue(TResult) ?? ""} - ").ToList());
                return new BllResponse<TDto>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = Mapper.Map<T, TDto>(TResult)
                };
            }
            catch (Exception ex)
            {
                return new BllResponse<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public virtual async Task<IBllResponse<TDto>> AddAsync(TDto item, bool saveChanges = true)
        {
            return Add(item, saveChanges);
        }

        public virtual IBllResponse<TDto> Update(TDto item, bool saveChanges = true)
        {
            var resolvedItem = String.Join(',', item.GetType().GetProperties().Select(x => $" - {x.Name} : {x.GetValue(item)} - ").ToList());
            try
            {
                var TResult = _repository.Update(Mapper.Map<T>(item));
                if (saveChanges) { Save(); }
                return new BllResponse<TDto>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = Mapper.Map<T, TDto>(TResult)
                };
            }
            catch (Exception ex)
            {
                return new BllResponse<TDto>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }

        public virtual async Task<IBllResponse<TDto>> UpdateAsync(TDto item, bool saveChanges = true)
        {
            return Update(item, saveChanges);
        }

        public void Save()
        {
            _uow.SaveChanges();
        }
    }
}