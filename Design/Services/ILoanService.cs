namespace Services;

using Models;
using DTOs;

public interface ILoanService
{
    Task<Loan> CreateLoanAsync(LoanDTO request);

    Task<Loan> UpdateLoanAsync(int id, LoanDTO request);

    Task<bool> DeleteLoanAsync(int id);

    Task<Loan> GetLoanAsync(int id);

    Task<ICollection<Loan>> GetAllLoansAsync();
    Task<ICollection<Loan>> GetLoansWithDuedatesCloseAsync(int daysToDuedate);
    Task<ICollection<Loan>> GetLoansWithPastDuedatesAsync();
}