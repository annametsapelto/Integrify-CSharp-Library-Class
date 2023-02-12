namespace Controllers;

using Models;
using Services;
using DTOs;

public class AddressController
{
    private readonly IAddressService _service;

    public AddressController(IAddressService service)
    {
        this._service = service;
    }

    //POST /api/addresses
    public async Task<Address> CreateAddressAsync(AddressDTO request)
    {
        var task = await _service.CreateAddressAsync(request);
        return task;
    }

    //PUT /api/addresses/{id}
    public async Task<Address> UpdateAddressAsync(int id, AddressDTO request)
    {
        var task = await _service.UpdateAddressAsync(id, request);
        return task;
    }

    //GET /api/addresses/{id}
    public async Task<Address> GetAddressAsync(int id)
    {
        var task = await _service.GetAddressAsync(id);
        return task;
    }

    //GET /api/addresses
    public async Task<ICollection<Address>> GetAllAddresss()
    {
        var task = await _service.GetAllAddressesAsync();
        return task;
    }

    //DELETE /api/addresses/{id}
    public async Task<bool> DeleteAddressAsync(int id)
    {
        var task = await _service.DeleteAddressAsync(id);
        return task;
    }
}