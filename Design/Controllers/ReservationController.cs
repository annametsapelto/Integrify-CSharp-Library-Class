namespace Controllers;

using Models;
using Services;
using DTOs;

public class ReservationController
{
    private readonly IReservationService _service;

    public ReservationController(IReservationService service)
    {
        this._service = service;
    }

    //POST /api/reservations
    public async Task<Reservation> CreateReservationAsync(ReservationDTO request)
    {
        var task = await _service.CreateReservationAsync(request);
        return task;
    }

    //PUT /api/reservations/{id}
    public async Task<Reservation> UpdateReservationAsync(int id, ReservationDTO request)
    {
        var task = await _service.UpdateReservationAsync(id, request);
        return task;
    }

    //GET /api/reservations/{id}
    public async Task<Reservation> GetReservationAsync(int id)
    {
        var task = await _service.GetReservationAsync(id);
        return task;
    }

    //GET /api/reservations
    public async Task<ICollection<Reservation>> GetAllReservations()
    {
        var task = await _service.GetAllReservationsAsync();
        return task;
    }

    //DELETE /api/reservations/{id}
    public async Task<bool> DeleteReservationAsync(int id)
    {
        var task = await _service.DeleteReservationAsync(id);
        return task;
    }
}