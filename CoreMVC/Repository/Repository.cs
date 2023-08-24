using CoreMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMVC.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DatabaseContext db;
        public Repository(DatabaseContext dBContext) 
        {
                db = dBContext;
        }
        public void Add(T entity)
        {
            db.Set<T>().AddAsync(entity);
            db.SaveChanges();
            
        }

        public void Delete(int id)
        {
            
           // List<T> tlist = db.Set<T>().ToList();
            T table= db.Set<T>().Find(id);
            db.Remove(table);
            db.SaveChanges();
           
           
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
            
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
           
        }

        public void Update(T entity)
        {
            // db.Set<T>().Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
           // db.Set<T>().Entry(entity);
            db.SaveChanges();
        }
    }
}
