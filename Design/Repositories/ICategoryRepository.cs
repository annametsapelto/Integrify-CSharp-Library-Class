namespace Repositories;

using Models;
using DTOs;

public interface ICategoryRepository
{
    Task<Category> CreateCategory(CategoryDTO request);

    Task<Category> UpdateCategory(int id, CategoryDTO request);

    Task<bool> DeleteCategory(int id);

    Task<Category> GetCategory(int id);

    Task<ICollection<Category>> GetAllCategories();
}