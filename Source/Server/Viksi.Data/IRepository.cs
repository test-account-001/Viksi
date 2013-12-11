namespace Viksi.Data
{
    using System.Linq;

    public interface IRepository<T> where T : class
    {
        IQueryable<T> All();

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        void Detach(T entity);
    }
}