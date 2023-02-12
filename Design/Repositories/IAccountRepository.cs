namespace Repositories;

using Models;
using DTOs;

public interface IAccountRepository
{
    Task<Account> CreateAccount(AccountDTO request);

    Task<Account> UpdateAccount(int id, AccountDTO request);

    Task<bool> DeleteAccount(int id);

    Task<Account> GetAccount(int id);

    Task<ICollection<Account>> GetAllAccounts();
}