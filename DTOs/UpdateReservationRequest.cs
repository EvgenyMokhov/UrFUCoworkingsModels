namespace UrFUCoworkingsModels.DTOs
{
    public class UpdateReservationRequest
    {
        public ReservationEdit Reservation { get; set; }
        public CSDTO Setting { get; set; }
    }
}
