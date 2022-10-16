using CompanyEmployees.Domain.Interfaces;
using CompanyEmployees.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace CompanyEmployees.Infrastructure.RepositoryBase
{
    public abstract class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected CompanyEmployeesDbContext CompanyEmployeesDbContext;

        public RepositoryBase(CompanyEmployeesDbContext companyEmployeesDbContext)
        {
            CompanyEmployeesDbContext = companyEmployeesDbContext;
        }

        public IQueryable<TEntity> FindAll(bool trackChanges)
        {
            return !trackChanges ? CompanyEmployeesDbContext.Set<TEntity>().AsNoTracking()
                                 : CompanyEmployeesDbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> FindByCondition(Expression<Func<TEntity, bool>> expression, bool trackChanges)
        {
            return !trackChanges ? CompanyEmployeesDbContext.Set<TEntity>().Where(expression).AsNoTracking()
                                 : CompanyEmployeesDbContext.Set<TEntity>().Where(expression);
        }

        public void Create(TEntity entity) => CompanyEmployeesDbContext.Set<TEntity>().Add(entity); 

        public void Update(TEntity entity) => CompanyEmployeesDbContext.Set<TEntity>().Update(entity); 

        public void Delete(TEntity entity) => CompanyEmployeesDbContext.Set<TEntity>().Remove(entity);
    }
}
