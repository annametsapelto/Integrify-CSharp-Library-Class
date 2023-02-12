namespace Repositories;

using Models;
using DTOs;

public interface IReservationRepository
{
    Task<Reservation> CreateReservation(ReservationDTO request);

    Task<Reservation> UpdateReservation(int id, ReservationDTO request);

    Task<bool> DeleteReservation(int id);

    Task<Reservation> GetReservation(int id);

    Task<ICollection<Reservation>> GetAllReservations();
}