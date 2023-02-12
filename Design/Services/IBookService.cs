namespace Services;

using Models;
using DTOs;

public interface IBookService
{
    Task<Book> CreateBookAsync(BookDTO request);

    Task<Book> UpdateBookAsync(int id, BookDTO request);

    Task<bool> DeleteBookAsync(int id);

    Task<Book> GetBookAsync(int id);

    Task<ICollection<Book>> GetAllBooksAsync();
    Task<ICollection<Book>> GetBooksByCategoryAsync(int categoryId);
    Task<ICollection<Book>> GetBooksByAuthorAsync(int authorId);
    Task<ICollection<Book>> GetBooksWithReservationsAsync();
    Task<ICollection<Book>> GetBooksByAvailabilityAsync(Availability status);

}