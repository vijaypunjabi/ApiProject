using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiProject.Database.Infrastructure
{
    public abstract class Repository<T> : IRepository<T> where T:class

    {
        protected ApiProjectContext ApiProjectContext { get; set; }
        public Repository(ApiProjectContext apiProjectContext)
        {
            this.ApiProjectContext = apiProjectContext;
        }

          //Crud Operations
        public virtual void Add(T entity)
        {
            ApiProjectContext.Add(entity);
            ApiProjectContext.SaveChanges();
        }

        public virtual void Add(List<T> entity)
        {
            ApiProjectContext.AddRange(entity);
            ApiProjectContext.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            ApiProjectContext.Set<T>().Remove(entity);
            ApiProjectContext.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            ApiProjectContext.Entry(entity).State =EntityState.Modified;
            ApiProjectContext.Set<T>().Update(entity);
            ApiProjectContext.SaveChanges();
        }

        public virtual async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> expression)
        {
            return await ApiProjectContext.Set<T>().Where(expression).ToListAsync();
        }

        public virtual async Task<T> GetDefault(Expression<Func<T, bool>> expression)
        {
            return await ApiProjectContext.Set<T>().Where(expression).FirstOrDefaultAsync();
        }

        public virtual async Task<IEnumerable<T>> Get()
        {
            return await ApiProjectContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await ApiProjectContext.Set<T>().FindAsync(id);    //ID DALNA BHULGYA THA DIYAN DE 
        }
    }
}
