namespace Repositories;

using Models;
using DTOs;

public interface ILoanRepository
{
    Task<Loan> CreateLoan(LoanDTO request);

    Task<Loan> UpdateLoan(int id, LoanDTO request);

    Task<bool> DeleteLoan(int id);

    Task<Loan> GetLoan(int id);

    Task<ICollection<Loan>> GetAllLoans();
}