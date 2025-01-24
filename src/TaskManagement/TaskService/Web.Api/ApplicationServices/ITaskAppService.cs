// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.TaskManagement.Task.Web.Api.Models;

namespace AnishCeDev.TaskManagement.Task.Web.Api.ApplicationServices
{
    public interface ITaskAppService
    {
        System.Threading.Tasks.Task AddNewTaskAsync(TaskModel task);
        Task<TaskModel> GetTaskAsync(int taskId);
        System.Threading.Tasks.Task UpdateTaskAsync(TaskModel task);
    }
}