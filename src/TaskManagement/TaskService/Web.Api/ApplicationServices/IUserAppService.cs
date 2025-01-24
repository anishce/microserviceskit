// ************************************************************************
// Copyright (c) 2025 AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.TaskManagement.Task.Web.Api.Models;

namespace AnishCeDev.TaskManagement.Task.Web.Api.ApplicationServices
{
    public interface IUserAppService
    {
        Task<UserModel> GetUserAsync(int userId);
        Task<IEnumerable<UserModel>> GetUsersAsync();
    }
}