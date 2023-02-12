namespace Controllers;

using Models;
using Services;
using DTOs;

public class BookController
{
    private readonly IBookService _service;

    public BookController(IBookService service)
    {
        this._service = service;
    }

    //POST /api/books
    public async Task<Book> CreateBookAsync(BookDTO request)
    {
        var task = await _service.CreateBookAsync(request);
        return task;
    }

    //PUT /api/books/{id}
    public async Task<Book> UpdateBookAsync(int id, BookDTO request)
    {
        var task = await _service.UpdateBookAsync(id, request);
        return task;
    }

    //GET /api/books/{id}
    public async Task<Book> GetBookAsync(int id)
    {
        var task = await _service.GetBookAsync(id);
        return task;
    }

    //GET /api/books
    public async Task<ICollection<Book>> GetAllBooks()
    {
        var task = await _service.GetAllBooksAsync();
        return task;
    }

    //DELETE /api/books/{id}
    public async Task<bool> DeleteBookAsync(int id)
    {
        var task = await _service.DeleteBookAsync(id);
        return task;
    }
}