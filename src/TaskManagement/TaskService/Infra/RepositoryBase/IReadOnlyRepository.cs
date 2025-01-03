using AnishCeDev.TaskManagement.Task.Infra.DomainBase;
using AnishCeDev.TaskManagement.Task.Infra.Querying;
using System.Collections.Generic;

namespace AnishCeDev.TaskManagement.Task.Infra.RepositoryBase
{
    public interface IReadOnlyRepository<T, TId> where T : IAggregateRoot 
    {
        T FindBy(TId id);
        IEnumerable<T> FindAll();        
        IEnumerable<T> FindBy(Query query);
        IEnumerable<T> FindBy(Query query, int index, int count);
    }
}
