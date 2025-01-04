// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.TaskManagement.Task.Web.Api.Models;

#pragma warning disable VSSpell001 // Spell Check
#pragma warning disable VSSpell001 // Spell Check
namespace AnishCeDev.TaskManagement.Task.Web.Api.ApplicationServices
#pragma warning restore VSSpell001 // Spell Check
#pragma warning restore VSSpell001 // Spell Check
{
#pragma warning disable VSSpell001 // Spell Check
    public class StatusAppService : IStatusAppService
#pragma warning restore VSSpell001 // Spell Check
    {
        public async Task<StatusModel> GetStatusAsync(int statusId)
        {
            return await System.Threading.Tasks.Task.Run(() => GetStatusModel());
        }

        public async Task<IEnumerable<StatusModel>> GetStatusesAsync()
        {
            return await System.Threading.Tasks.Task.Run(() => GetStatusList());
        }


        private StatusModel GetStatusModel()
        {
            return new StatusModel
            {
                StatusId = 1,
                Ordinal = 2,
                Name = "In Progress",
                Links = new List<LinkModel>
                {
                    new LinkModel
                    {
                        Href="https://www.google.com",
                        Rel="",
                        Title="Google",
                        Type="HyperLink"
                    }
                }
            };
        }

        private IEnumerable<StatusModel> GetStatusList()
        {
            return new List<StatusModel>
            {
                new StatusModel
                {
                    StatusId = 1,
                    Ordinal = 2,
                    Name = "In Progress",
                    Links = new List<LinkModel>
                    {
                        new LinkModel
                        {
                            Href="https://www.google.com",
                            Rel="",
                            Title="Google",
                            Type="HyperLink"
                        }
                    }
                }
            };
        }
    }
}
