namespace Repositories;

using Models;
using DTOs;

public interface IOverduePaymentRepository
{
    Task<OverduePayment> CreateOverduePaymentAsync(OverduePaymentDTO request);

    Task<OverduePayment> UpdateOverduePaymentAsync(int id, OverduePaymentDTO request);

    Task<bool> DeleteOverduePaymentAsync(int id);

    Task<OverduePayment> GetOverduePaymentAsync(int id);

    Task<ICollection<OverduePayment>> GetAllOverduePaymentsAsync();
}