using Contacts.Domain;

namespace  Contacts.Application.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        Task<T> GetById(int id);
        Task<List<T>> GetAll();
    }
}
