namespace Repositories;

using Models;
using DTOs;

public interface IAddressRepository
{
    Task<Address> CreateAddressAsync(AddressDTO request);

    Task<Address> UpdateAddressAsync(int id, AddressDTO request);

    Task<bool> DeleteAddressAsync(int id);

    Task<Address> GetAddressAsync(int id);

    Task<ICollection<Address>> GetAllAddressesAsync();
}