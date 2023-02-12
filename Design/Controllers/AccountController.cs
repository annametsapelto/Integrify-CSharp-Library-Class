namespace Controllers;

using Models;
using Services;
using DTOs;

public class AccountController
{
    private readonly IAccountService _service;

    public AccountController(IAccountService service)
    {
        this._service = service;
    }

    //POST /api/accounts
    public async Task<Account> CreateAccountAsync(AccountDTO request)
    {
        var task = await _service.CreateAccountAsync(request);
        return task;
    }

    //PUT /api/accounts/{id}
    public async Task<Account> UpdateAccountAsync(int id, AccountDTO request)
    {
        var task = await _service.UpdateAccountAsync(id, request);
        return task;
    }

    //GET /api/accounts/{id}
    public async Task<Account> GetAccountAsync(int id)
    {
        var task = await _service.GetAccountAsync(id);
        return task;
    }

    //GET /api/accounts
    public async Task<ICollection<Account>> GetAllAccounts()
    {
        var task = await _service.GetAllAccountsAsync();
        return task;
    }

    //DELETE /api/accounts/{id}
    public async Task<bool> DeleteAccountAsync(int id)
    {
        var task = await _service.DeleteAccountAsync(id);
        return task;
    }
}