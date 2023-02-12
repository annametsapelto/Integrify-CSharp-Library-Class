namespace Controllers;

using Models;
using Services;
using DTOs;

public class LoanController
{
    private readonly ILoanService _service;

    public LoanController(ILoanService service)
    {
        this._service = service;
    }

    //POST /api/loans
    public async Task<Loan> CreateLoanAsync(LoanDTO request)
    {
        var task = await _service.CreateLoanAsync(request);
        return task;
    }

    //PUT /api/loans/{id}
    public async Task<Loan> UpdateLoanAsync(int id, LoanDTO request)
    {
        var task = await _service.UpdateLoanAsync(id, request);
        return task;
    }

    //GET /api/loans/{id}
    public async Task<Loan> GetLoanAsync(int id)
    {
        var task = await _service.GetLoanAsync(id);
        return task;
    }

    //GET /api/loans
    public async Task<ICollection<Loan>> GetAllLoans()
    {
        var task = await _service.GetAllLoansAsync();
        return task;
    }

    //DELETE /api/loans/{id}
    public async Task<bool> DeleteLoanAsync(int id)
    {
        var task = await _service.DeleteLoanAsync(id);
        return task;
    }
}