using Scrumler.Entity.Base;
using Scrumler.Interface.Base;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scrumler.WebApi.Base
{
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ApiBase<TInterface, T, TDto> : ControllerBase where TInterface : IBllBase<T, TDto> where T : EntityBase where TDto : DtoBase
    {
        #region Variables

        private readonly TInterface _bll;

        #endregion Variables

        #region Constructor

        public ApiBase(TInterface bll)
        {
            _bll = bll;
        }

        #endregion Constructor

        #region GetMethods

        [HttpGet("Find")]
        public virtual IBllResponse<TDto> Find(int id)
        {
            try
            {
                return _bll.Find(id);
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

        [HttpGet("GetAll")]
        public virtual IBllResponse<List<TDto>> GetAll()
        {
            try
            {
                return _bll.GetAll();
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

        [HttpGet("GetQueryable")]
        public virtual IQueryable<T> GetQueryable()
        {
            try
            {
                return _bll.GetQueryable();
            }
            catch (Exception Ex)
            {
                return null;
            }
        }

        #endregion GetMethods

        #region PostMethods

        [HttpPost("DeleteById")]
        public virtual IBllResponse<string> DeleteById(int id)
        {
            try
            {
                return _bll.DeleteById(id);
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

        [HttpPost("DeleteByIdAsync")]
        public virtual async Task<IBllResponse<string>> DeleteByIdAsync(int id)
        {
            return DeleteById(id);
        }

        [HttpPost("Delete")]
        public virtual IBllResponse<string> Delete([FromBody] TDto item)
        {
            try
            {
                return _bll.Delete(item);
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

        [HttpPost("DeleteAsync")]
        public virtual async Task<IBllResponse<string>> DeleteAsync([FromBody] TDto item)
        {
            return Delete(item);
        }

        [HttpPost("Add")]
        public virtual IBllResponse<TDto> Add([FromBody] TDto item)
        {
            try
            {
                return _bll.Add(item);
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

        [HttpPost("AddAsync")]
        public virtual async Task<IBllResponse<TDto>> AddAsync([FromBody] TDto item)
        {
            return Add(item);
        }

        [HttpPost("Update")]
        public virtual IBllResponse<TDto> Update([FromBody] TDto item)
        {
            try
            {
                return _bll.Update(item);
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

        [HttpPost("UpdateAsync")]
        public virtual async Task<IBllResponse<TDto>> UpdateAsync([FromBody] TDto item)
        {
            return Update(item);
        }

        #endregion PostMethods

        #region SaveChanges

        private void Save()
        {
            _bll.Save();
        }

        #endregion SaveChanges
    }
}