// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

namespace AnishCeDev.TaskManagement.Task.Infra.DomainBase
{
    public abstract class BaseValueObject<T> where T : BaseValueObject<T>
    {
        public BaseValueObject()
        {

        }

        protected abstract IEnumerable<object> GetAttributesToBeCheckForEquality();

        protected abstract void Validate();
    }
}