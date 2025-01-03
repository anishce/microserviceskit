using AnishCeDev.TaskManagement.Task.Infra.DomainBase;

namespace AnishCeDev.TaskManagement.Task.Infra.RepositoryBase
{
    public interface IRepository<T, TId> : IReadOnlyRepository<T, TId> where T : IAggregateRoot
    {
        void Save(T entity);
        void Add(T entity);
        void Remove(T entity);
    }
}
