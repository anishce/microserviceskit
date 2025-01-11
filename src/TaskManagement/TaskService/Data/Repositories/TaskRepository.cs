// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.TaskManagement.Task.Infra.Querying;
using AnishCeDev.TaskManagement.Task.Infra.RepositoryBase;

namespace AnishCeDev.TaskManagement.Task.Data.Repositories
{
    internal class TaskRepository : RepositoryBase<AnishCeDev.TaskManagement.Task.Domain.TaskAggregate.Task, int>
    {
        public override void Add(Domain.TaskAggregate.Task entity)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Domain.TaskAggregate.Task> FindAll()
        {
            throw new NotImplementedException();
        }

        public override Domain.TaskAggregate.Task FindBy(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Domain.TaskAggregate.Task> FindBy(Query query)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Domain.TaskAggregate.Task> FindBy(Query query, int index, int count)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Domain.TaskAggregate.Task entity)
        {
            throw new NotImplementedException();
        }

        public override void Save(Domain.TaskAggregate.Task entity)
        {
            throw new NotImplementedException();
        }
    }
}
