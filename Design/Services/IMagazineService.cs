namespace Services;

using Models;
using DTOs;

public interface IMagazineService
{
    Task<Magazine> CreateMagazineAsync(MagazineDTO request);

    Task<Magazine> UpdateMagazineAsync(int id, MagazineDTO request);

    Task<bool> DeleteMagazineAsync(int id);

    Task<Magazine> GetMagazineAsync(int id);

    Task<ICollection<Magazine>> GetAllMagazinesAsync();
    Task<ICollection<Magazine>> GetMagazinesByCategoryAsync(int categoryId);
    Task<ICollection<Magazine>> GetMagazinesByAuthorAsync(int authorId);
    Task<ICollection<Magazine>> GetMagazinesWithReservationsAsync();
    Task<ICollection<Magazine>> GetMagazinesByAvailabilityAsync(Availability status);

}