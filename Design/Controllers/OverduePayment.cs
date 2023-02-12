namespace Controllers;

using Models;
using Services;
using DTOs;

public class OverduePaymentController
{
    private readonly IOverduePaymentService _service;

    public OverduePaymentController(IOverduePaymentService service)
    {
        this._service = service;
    }

    //POST /api/overduePayments
    public async Task<OverduePayment> CreateOverduePaymentAsync(OverduePaymentDTO request)
    {
        var task = await _service.CreateOverduePaymentAsync(request);
        return task;
    }

    //PUT /api/overduePayments/{id}
    public async Task<OverduePayment> UpdateOverduePaymentAsync(int id, OverduePaymentDTO request)
    {
        var task = await _service.UpdateOverduePaymentAsync(id, request);
        return task;
    }

    //GET /api/overduePayments/{id}
    public async Task<OverduePayment> GetOverduePaymentAsync(int id)
    {
        var task = await _service.GetOverduePaymentAsync(id);
        return task;
    }

    //GET /api/overduePayments
    public async Task<ICollection<OverduePayment>> GetAllOverduePayments()
    {
        var task = await _service.GetAllOverduePaymentsAsync();
        return task;
    }

    //DELETE /api/overduePayments/{id}
    public async Task<bool> DeleteOverduePaymentAsync(int id)
    {
        var task = await _service.DeleteOverduePaymentAsync(id);
        return task;
    }
}