using AnishCeDev.CoachingMentoring.Coaching.Infra.DomainBase;
using AnishCeDev.CoachingMentoring.Coaching.Infra.Querying;
using System.Collections.Generic;

namespace AnishCeDev.CoachingMentoring.Coaching.Infra.RepositoryBase
{
    public interface IReadOnlyRepository<T, TId> where T : IAggregateRoot 
    {
        T FindBy(TId id);
        IEnumerable<T> FindAll();        
        IEnumerable<T> FindBy(Query query);
        IEnumerable<T> FindBy(Query query, int index, int count);
    }
}
