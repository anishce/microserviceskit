﻿namespace AnishCeDev.CoachingMentoring.Coaching.Infra.DomainBase
{
    public abstract class BaseEntity<TId> : IEntity
    {
        public BaseEntity(TId id,int version)
        {
            Id = id;
            Version = version;
        }

        public TId Id { get; private set; } = default!;

        public int Version { get; private set; }

        protected abstract void ValidateEntity();
    }
}