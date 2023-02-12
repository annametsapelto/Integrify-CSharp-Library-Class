namespace Services;

using Models;
using DTOs;

public interface IAccountService
{
    Task<Account> CreateAccountAsync(AccountDTO request);

    Task<Account> UpdateAccountAsync(int id, AccountDTO request);

    Task<bool> DeleteAccountAsync(int id);

    Task<Account> GetAccountAsync(int id);

    Task<ICollection<Account>> GetAllAccountsAsync();
    Task<ICollection<Account>> GetActiveAccounts();
    Task<ICollection<Account>> GetAccountsWithLoans();
    Task<ICollection<Account>> GetAccountsWithReservations();

}