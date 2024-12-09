namespace UrFUCoworkingsModels.DTOs
{
    public class CreateReservationRequest
    {
        public ReservationEdit Reservation { get; set; }
        public CSDTO Setting { get; set; }
    }
}
