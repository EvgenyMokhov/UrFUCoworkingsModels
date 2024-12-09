using UrFUCoworkingsModels.DTOs;

namespace UrFUCoworkingsModels.Requests.Reservations
{
    public class UpdateReservationRequest
    {
        public ReservationEdit RequestData { get; set; }
        public CSDTO Setting { get; set; }
    }
}
