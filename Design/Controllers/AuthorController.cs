namespace Controllers;

using Models;
using Services;
using DTOs;

public class AuthorController
{
    private readonly IAuthorService _service;

    public AuthorController(IAuthorService service)
    {
        this._service = service;
    }

    //POST /api/authors
    public async Task<Author> CreateAuthorAsync(AuthorDTO request)
    {
        var task = await _service.CreateAuthorAsync(request);
        return task;
    }

    //PUT /api/authors/{id}
    public async Task<Author> UpdateAuthorAsync(int id, AuthorDTO request)
    {
        var task = await _service.UpdateAuthorAsync(id, request);
        return task;
    }

    //GET /api/authors/{id}
    public async Task<Author> GetAuthorAsync(int id)
    {
        var task = await _service.GetAuthorAsync(id);
        return task;
    }

    //GET /api/authors
    public async Task<ICollection<Author>> GetAllAuthors()
    {
        var task = await _service.GetAllAuthorsAsync();
        return task;
    }

    //DELETE /api/authors/{id}
    public async Task<bool> DeleteAuthorAsync(int id)
    {
        var task = await _service.DeleteAuthorAsync(id);
        return task;
    }
}