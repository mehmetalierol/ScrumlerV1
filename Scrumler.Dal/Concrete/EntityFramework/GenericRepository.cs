using Scrumler.Entity.Base;
using Scrumler.Interface.Base;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Scrumler.Dal.Concrete.EntityFramework
{
    public class GenericRepository<T> : IGenericRepository<T> where T : EntityBase
    {
        #region Variables

        protected DbContext _context;

        protected DbSet<T> _dbset;

        #endregion Variables

        #region Constructor

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        #endregion Constructor

        #region GetterMethods

        public IQueryable<T> GetAll(Expression<System.Func<T, object>> includePart = null, Expression<System.Func<T, bool>> wherePart = null)
        {
            if (includePart != null || wherePart != null)
            {
                if (includePart == null)
                {
                    return _dbset.Where(wherePart);
                }
                else if (wherePart == null)
                {
                    return _dbset.Include(includePart);
                }
                else
                {
                    return _dbset.Where(wherePart).Include(includePart);
                }
            }
            else
            {
                return _dbset;
            }
        }

        public IQueryable<T> GetAll(List<Expression<System.Func<T, object>>> includePart = null, Expression<System.Func<T, bool>> wherePart = null)
        {
            if (includePart != null)
            {
                foreach (var item in includePart)
                {
                    _dbset.Include(item);
                }
            }
            if (wherePart != null)
            {
                _dbset.Where(wherePart);
            }

            return _dbset;
        }

        public IQueryable<TResult> GetWithSelect<TResult>(Expression<System.Func<T, TResult>> selectPart, Expression<System.Func<T, object>> includePart = null, Expression<System.Func<T, bool>> wherePart = null)
        {
            if (includePart != null || wherePart != null)
            {
                if (includePart == null)
                {
                    return _dbset.Where(wherePart).Select(selectPart);
                }
                else if (wherePart == null)
                {
                    return _dbset.Include(includePart).Select(selectPart);
                }
                else
                {
                    return _dbset.Where(wherePart).Include(includePart).Select(selectPart);
                }
            }
            else
            {
                return _dbset.Select(selectPart);
            }
        }

        public IQueryable<TResult> GetWithSelect<TResult>(Expression<System.Func<T, TResult>> selectPart, List<Expression<System.Func<T, object>>> includePart = null, Expression<System.Func<T, bool>> wherePart = null)
        {
            if (includePart != null)
            {
                foreach (var item in includePart)
                {
                    _dbset.Include(item);
                }
            }
            if (wherePart != null)
            {
                _dbset.Where(wherePart);
            }

            return _dbset.Select(selectPart);
        }

        public T Find(int Id)
        {
            return _dbset.Find(Id);
        }

        #endregion GetterMethods

        #region SetterMethods

        public T Update(T entityToUpdate)
        {
            _dbset.Update(entityToUpdate);
            return entityToUpdate;
        }

        public T Add(T entity)
        {
            _dbset.Add(entity);
            return entity;
        }

        public void Delete(int Id)
        {
            Delete(Find(Id));
        }

        public void Delete(T entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _context.Attach(entityToDelete);
            }
            _dbset.Remove(entityToDelete);
        }

        #endregion SetterMethods
    }
}