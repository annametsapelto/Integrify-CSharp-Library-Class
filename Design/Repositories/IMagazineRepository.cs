namespace Repositories;

using Models;
using DTOs;

public interface IMagazineRepository
{
    Task<Magazine> CreateMagazineAsync(MagazineDTO request);

    Task<Magazine> UpdateMagazineAsync(int id, MagazineDTO request);

    Task<bool> DeleteMagazineAsync(int id);

    Task<Magazine> GetMagazineAsync(int id);

    Task<ICollection<Magazine>> GetAllMagazinesAsync();
}