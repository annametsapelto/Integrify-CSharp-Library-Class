namespace Repositories;

using Models;
using DTOs;

public interface IReservationRepository
{
    Task<Reservation> CreateReservationAsync(ReservationDTO request);

    Task<Reservation> UpdateReservationAsync(int id, ReservationDTO request);

    Task<bool> DeleteReservationAsync(int id);

    Task<Reservation> GetReservationAsync(int id);

    Task<ICollection<Reservation>> GetAllReservationsAsync();
}