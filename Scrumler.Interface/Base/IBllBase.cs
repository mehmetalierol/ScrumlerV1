using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scrumler.Interface.Base
{
    public interface IBllBase<T, TDto> where T : IEntityBase where TDto : IDtoBase
    {
        #region GetMethods

        IBllResponse<List<TDto>> GetAll();

        IBllResponse<TDto> Find(int id);

        IQueryable<T> GetQueryable();

        #endregion GetMethods

        #region PostMethods

        IBllResponse<TDto> Add(TDto item, bool saveChanges = true);

        Task<IBllResponse<TDto>> AddAsync(TDto item, bool saveChanges = true);

        IBllResponse<TDto> Update(TDto item, bool saveChanges = true);

        Task<IBllResponse<TDto>> UpdateAsync(TDto item, bool saveChanges = true);

        IBllResponse<string> Delete(TDto item, bool saveChanges = true);

        Task<IBllResponse<string>> DeleteAsync(TDto item, bool saveChanges = true);

        IBllResponse<string> DeleteById(int Id, bool saveChanges = true);

        Task<IBllResponse<string>> DeleteByIdAsync(int id, bool saveChanges = true);

        void Save();

        #endregion PostMethods
    }
}