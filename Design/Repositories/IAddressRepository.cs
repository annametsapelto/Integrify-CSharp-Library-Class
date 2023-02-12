namespace Repositories;

using Models;
using DTOs;

public interface IAddressRepository
{
    Task<Address> CreateAddress(AddressDTO request);

    Task<Address> UpdateAddress(int id, AddressDTO request);

    Task<bool> DeleteAddress(int id);

    Task<Address> GetAddress(int id);

    Task<ICollection<Address>> GetAllAddresses();
}