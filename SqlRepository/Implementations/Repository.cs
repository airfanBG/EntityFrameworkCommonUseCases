using Microsoft.EntityFrameworkCore;
using SqlRepository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlRepository.Implementations
{
    internal class Repository<T> : IRepository<T> where T : class
    {
        public Repository(DbContext dbContext)
        {
            DbContext = dbContext;
            this.DbSet= dbContext.Set<T>();
        }

        private DbContext DbContext { get; }
        private DbSet<T> DbSet { get; }
        public int Add(T item)
        {
            try
            {
                this.DbSet.Add(item);
                return this.DbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<T> AllAsNoTracking()
        {
            return this.DbSet.AsNoTracking();
        }

        public int Delete(T item)
        {
            try
            {
                this.DbSet.Remove(item);
                //this.DbContext.Set<T>().Remove(item); 
                return this.DbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose() => this.DbContext.Dispose();
        

        public IQueryable<T> GetAll(Func<T, bool> predicate = null)
        {
            try
            {
                if (predicate!=null)
                {
                    return this.DbSet.Where(predicate).AsQueryable();
                }
                return this.DbSet.AsQueryable();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public T GetById(int id)
        {
            try
            {
                return this.DbSet.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int SaveChanges()
        {
            return this.DbContext.SaveChanges();
        }

        public int Update(T item)
        {
            try
            {
                this.DbSet.Update(item);
                //this.DbContext.Set<T>().Update(item); 
                return this.DbContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
