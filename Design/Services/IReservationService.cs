namespace Services;

using Models;
using DTOs;

public interface IReservationService
{
    Task<Reservation> CreateReservationAsync(ReservationDTO request);

    Task<Reservation> UpdateReservationAsync(int id, ReservationDTO request);

    Task<bool> DeleteReservationAsync(int id);

    Task<Reservation> GetReservationAsync(int id);

    Task<ICollection<Reservation>> GetAllReservationsAsync();
    Task<ICollection<Reservation>> GetReservationsByCategoryAsync(int categoryId);
    Task<ICollection<Reservation>> GetReservationsByAuthorAsync(int authorId);
    Task<ICollection<Reservation>> GetReservationsByAvailabilityAsync(Availability status);

}