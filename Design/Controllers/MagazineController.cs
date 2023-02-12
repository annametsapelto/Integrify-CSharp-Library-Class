namespace Controllers;

using Models;
using Services;
using DTOs;

public class MagazineController
{
    private readonly IMagazineService _service;

    public MagazineController(IMagazineService service)
    {
        this._service = service;
    }

    //POST /api/magazines
    public async Task<Magazine> CreateMagazineAsync(MagazineDTO request)
    {
        var task = await _service.CreateMagazineAsync(request);
        return task;
    }

    //PUT /api/magazines/{id}
    public async Task<Magazine> UpdateMagazineAsync(int id, MagazineDTO request)
    {
        var task = await _service.UpdateMagazineAsync(id, request);
        return task;
    }

    //GET /api/magazines/{id}
    public async Task<Magazine> GetMagazineAsync(int id)
    {
        var task = await _service.GetMagazineAsync(id);
        return task;
    }

    //GET /api/magazines
    public async Task<ICollection<Magazine>> GetAllMagazines()
    {
        var task = await _service.GetAllMagazinesAsync();
        return task;
    }

    //DELETE /api/magazines/{id}
    public async Task<bool> DeleteMagazineAsync(int id)
    {
        var task = await _service.DeleteMagazineAsync(id);
        return task;
    }
}