﻿// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.TaskManagement.Domain.Shared;
using AnishCeDev.TaskManagement.Task.Infra.DomainBase;

namespace AnishCeDev.TaskManagement.Task.Domain.PriorityAggregate
{
    public class Priority : BaseEntity<int>, IAggregateRoot
    {
        public Priority(int id, string name, int ordinal, IEnumerable<Link> links, int version) : base(id, version)
        {
            Name = name;
            Ordinal = ordinal;
            Links = links;
        }

        public string Name { get; private set; } = null!;
        public int? Ordinal { get; private set; }
        public IEnumerable<Link> Links { get; private set; } = null!;

        protected override void ValidateEntity()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                throw new ArgumentNullException("Name");
            }

            if (Links is null || Links?.Count() <= 0)
            {
                throw new ArgumentNullException("Links");
            }
        }
    }
}
