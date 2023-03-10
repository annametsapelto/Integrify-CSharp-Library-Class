namespace Repositories;

using Models;
using DTOs;

public interface ILoanRepository
{
    Task<Loan> CreateLoanAsync(LoanDTO request);

    Task<Loan> UpdateLoanAsync(int id, LoanDTO request);

    Task<bool> DeleteLoanAsync(int id);

    Task<Loan> GetLoanAsync(int id);

    Task<ICollection<Loan>> GetAllLoansAsync();
}