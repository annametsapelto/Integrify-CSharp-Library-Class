namespace Repositories;

using Models;
using DTOs;

public interface IBookRepository
{
    Task<Book> CreateBook(BookDTO request);

    Task<Book> UpdateBook(int id, BookDTO request);

    Task<bool> DeleteBook(int id);

    Task<Book> GetBook(int id);

    Task<ICollection<Book>> GetAllBooks();
}