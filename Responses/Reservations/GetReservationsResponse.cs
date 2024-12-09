using UrFUCoworkingsModels.DTOs;

namespace UrFUCoworkingsModels.Responses.Reservations
{
    public record GetReservationsResponse
    {
        public List<ReservationView> ResponseData { get; set; }
    }
}
