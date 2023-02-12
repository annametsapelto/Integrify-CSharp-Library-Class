namespace Repositories;

using Models;
using DTOs;

public interface IMagazineRepository
{
    Task<Magazine> CreateMagazine(MagazineDTO request);

    Task<Magazine> UpdateMagazine(int id, MagazineDTO request);

    Task<bool> DeleteMagazine(int id);

    Task<Magazine> GetMagazine(int id);

    Task<ICollection<Magazine>> GetAllMagazines();
}