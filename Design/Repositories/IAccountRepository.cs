namespace Repositories;

using Models;
using DTOs;

public interface IAccountRepository
{
    Task<Account> CreateAccountAsync(AccountDTO request);

    Task<Account> UpdateAccountAsync(int id, AccountDTO request);

    Task<bool> DeleteAccountAsync(int id);

    Task<Account> GetAccountAsync(int id);

    Task<ICollection<Account>> GetAllAccountsAsync();
}