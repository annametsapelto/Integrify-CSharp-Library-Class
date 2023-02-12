namespace Repositories;

using Models;
using DTOs;

public interface IOverduePaymentRepository
{
    Task<OverduePayment> CreateOverduePayment(OverduePaymentDTO request);

    Task<OverduePayment> UpdateOverduePayment(int id, OverduePaymentDTO request);

    Task<bool> DeleteOverduePayment(int id);

    Task<OverduePayment> GetOverduePayment(int id);

    Task<ICollection<OverduePayment>> GetAllOverduePayments();
}