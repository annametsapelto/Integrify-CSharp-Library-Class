namespace Services;

using Models;
using DTOs;

public interface IAddressService
{
    Task<Address> CreateAddressAsync(AddressDTO request);

    Task<Address> UpdateAddressAsync(int id, AddressDTO request);

    Task<bool> DeleteAddressAsync(int id);

    Task<Address> GetAddressAsync(int id);

    Task<ICollection<Address>> GetAllAddressesAsync();
    Task<ICollection<Address>> GetAddressesInAreaAsync(string zip);
    Task<ICollection<Address>> GetAllAddressesInCountryAsync(string country);
}