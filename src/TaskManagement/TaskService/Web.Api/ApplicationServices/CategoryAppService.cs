// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

// Ignore Spelling: Anish App Api

using AnishCeDev.TaskManagement.Task.Web.Api.Models;
using Task = System.Threading.Tasks.Task;

namespace AnishCeDev.TaskManagement.Task.Web.Api.ApplicationServices
{
    public class CategoryAppService : ICategoryAppService
    {
        public async System.Threading.Tasks.Task AddCategoryAsync(CategoryModel category)
        {
            await System.Threading.Tasks.Task.Run(() => AddNewCategory(category));
        }

        public async System.Threading.Tasks.Task UpdateCategoryAsync(CategoryModel category)
        {
            await System.Threading.Tasks.Task.Run(() => UpdateCategory(category));
        }

        public async System.Threading.Tasks.Task UpdateCategoriesAsync(IEnumerable<CategoryModel> categories)
        {
            await System.Threading.Tasks.Task.Run(() => UpdateCategories(categories));
        }

        public async System.Threading.Tasks.Task RemoveCategoryAsync(int categoryId)
        {
            await System.Threading.Tasks.Task.Run(() => RemoveCategory(categoryId));
        }

        public async System.Threading.Tasks.Task RemoveCategoriesAsync(IEnumerable<int> categoryIds)
        {
            await System.Threading.Tasks.Task.Run(() => RemoveCategories(categoryIds));
        }

        public async Task<CategoryModel> GetCategoryAsync(int categoryId)
        {
            return await System.Threading.Tasks.Task.Run(() => GetCategoryModel(categoryId));
        }

        public async Task<IEnumerable<CategoryModel>> GetCategoriesAsync()
        {
            return await System.Threading.Tasks.Task.Run(() => GetCategoryModels());
        }

        private IEnumerable<CategoryModel> GetCategoryModels()
        {
            return new List<CategoryModel>
            {
                new CategoryModel
                {
                    CategoryId = 1,
                    Description = "Test",
                    Links = new List<LinkModel>
                    {
                        new LinkModel
                        {
                            Href="https://www.google.com",
                            Rel="",
                            Title="Google",
                            Type="HyperLink"
                        }
                    },
                    Name = "HyperLink Category"
                }
            };
        }

        private CategoryModel GetCategoryModel(int categoryId)
        {
            return new CategoryModel
            {
                CategoryId = categoryId,
                Description = "Test",
                Links = new List<LinkModel>
                {
                    new LinkModel
                    {
                        Href="https://www.google.com",
                        Rel="",
                        Title="Google",
                        Type="HyperLink"
                    }
                },
                Name = "HyperLink Category"
            };
        }

        private void AddNewCategory(CategoryModel category)
        {

        }

        private void UpdateCategory(CategoryModel category)
        {

        }

        private void UpdateCategories(IEnumerable<CategoryModel> categories)
        {

        }

        private void RemoveCategory(int categoryId)
        {

        }

        private void RemoveCategories(IEnumerable<int> categoryIds)
        {

        }
    }
}
