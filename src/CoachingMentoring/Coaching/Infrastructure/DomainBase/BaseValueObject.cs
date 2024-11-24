using System.Collections.Generic;

namespace AnishCeDev.CoachingMentoring.Coaching.Infra.DomainBase
{
    public abstract class BaseValueObject<T> where T: BaseValueObject<T>
    {
        public BaseValueObject()
        {
        
        }

        protected abstract IEnumerable<object> GetAttributesToBeCheckForEquality();

        protected abstract void Validate();
    }
}