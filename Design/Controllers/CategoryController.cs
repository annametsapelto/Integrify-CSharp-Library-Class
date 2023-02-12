namespace Controllers;

using Models;
using Services;
using DTOs;

public class CategoryController
{
    private readonly ICategoryService _service;

    public CategoryController(ICategoryService service)
    {
        this._service = service;
    }

    //POST /api/categories
    public async Task<Category> CreateCategoryAsync(CategoryDTO request)
    {
        var task = await _service.CreateCategoryAsync(request);
        return task;
    }

    //PUT /api/categories/{id}
    public async Task<Category> UpdateCategoryAsync(int id, CategoryDTO request)
    {
        var task = await _service.UpdateCategoryAsync(id, request);
        return task;
    }

    //GET /api/categories/{id}
    public async Task<Category> GetCategoryAsync(int id)
    {
        var task = await _service.GetCategoryAsync(id);
        return task;
    }

    //GET /api/categories
    public async Task<ICollection<Category>> GetAllCategories()
    {
        var task = await _service.GetAllCategoriesAsync();
        return task;
    }

    //DELETE /api/categories/{id}
    public async Task<bool> DeleteCategoryAsync(int id)
    {
        var task = await _service.DeleteCategoryAsync(id);
        return task;
    }
}