// ************************************************************************
// Copyright (c) AnishCeDev All Rights Reserved.
// Author: AnishCeDev
// ************************************************************************

using AnishCeDev.TaskManagement.Task.Web.Api.Models;

namespace AnishCeDev.TaskManagement.Task.Web.Api.ApplicationServices
{
    public interface ICategoryAppService
    {
        System.Threading.Tasks.Task AddCategoryAsync(CategoryModel category);
        Task<CategoryModel> GetCategoryAsync(int categoryId);
        Task<IEnumerable<CategoryModel>> GetCategoriesAsync();
        System.Threading.Tasks.Task RemoveCategoriesAsync(IEnumerable<int> categoryIds);
        System.Threading.Tasks.Task RemoveCategoryAsync(int categoryId);
        System.Threading.Tasks.Task UpdateCategoriesAsync(IEnumerable<CategoryModel> categories);
        System.Threading.Tasks.Task UpdateCategoryAsync(CategoryModel category);
    }
}