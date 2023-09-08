using CoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMVC.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DatabaseContext _db;
        public Repository(DatabaseContext dbContext) 
        {
                _db = dbContext;
        }
        public void Add(T entity)
        {
            _db.Set<T>().AddAsync(entity);
            _db.SaveChanges();
           
        }

        public void Delete(int id)
        {
            T table= _db.Set<T>().Find(id);
            _db.Remove(table);
            _db.SaveChanges();                  
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
            
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
           
        }

        public void Update(T entity)
        {
            // _db.Set<T>().Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
