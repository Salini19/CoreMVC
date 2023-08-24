namespace CoreMVC.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        List<T> GetAll();
        T GetById(int id);

        void Update(T entity);
        void Delete(int id);

    }
}
