using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlRepository.Contracts
{
    internal interface IRepository<T>:IDisposable where T : class
    {
        public IQueryable<T> GetAll(Func<T, bool> predicate=null);
        IQueryable<T> AllAsNoTracking();
        public int Add(T item);
        public int Update(T item);
        public int Delete(T item);
        public T GetById(int id);
       
        int SaveChanges();
    }
}
