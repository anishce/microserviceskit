﻿// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.TaskManagement.Task.Web.Api.Models;

namespace AnishCeDev.TaskManagement.Task.Web.Api.ApplicationServices
{
    public class UserAppService : IUserAppService
    {
        public async Task<UserModel> GetUserAsync(int userId)
        {
            return await System.Threading.Tasks.Task.Run(() => GetUserModel(userId));
        }

        public async Task<IEnumerable<UserModel>> GetUsersAsync()
        {
            return await System.Threading.Tasks.Task.Run(() => GetUserModels());
        }

        private IEnumerable<UserModel> GetUserModels()
        {
            return new List<UserModel>
            {
                new UserModel
                {
                    UserId = 1,
                    Firstname="John",
                    Lastname="Doe",
                    Email="john.doe@test.test",
                    Username="john.doe"
                },
                new UserModel
                {
                    UserId = 2,
                    Firstname="Kevin",
                    Lastname="White",
                    Email="kevin.white@test.test",
                    Username="kevin.white"
                }
            };
        }

        private UserModel GetUserModel(int userId)
        {
            return new UserModel
            {
                UserId = userId,
                Firstname = "John",
                Lastname = "Doe",
                Email = "john.doe@test.test",
                Username = "john.doe"
            };
        }
    }
}
