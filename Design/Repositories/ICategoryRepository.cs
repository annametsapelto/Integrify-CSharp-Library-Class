namespace Repositories;

using Models;
using DTOs;

public interface ICategoryRepository
{
    Task<Category> CreateCategoryAsync(CategoryDTO request);

    Task<Category> UpdateCategoryAsync(int id, CategoryDTO request);

    Task<bool> DeleteCategoryAsync(int id);

    Task<Category> GetCategoryAsync(int id);

    Task<ICollection<Category>> GetAllCategoriesAsync();
}