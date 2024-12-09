namespace UrFUCoworkingsModels.DTOs
{
    public class ReservationEdit
    {
        public Guid ReservationId { get; set; }
        public Guid ReservatorId { get; set; }
        public DateOnly ReservationDay { get; set; }
        public TimeOnly ReservationBegin { get; set; }
        public TimeOnly ReservationEnd { get; set; }
        public List<Guid> PlacesIds { get; set; } = new();
        public List<Guid> UserIds { get; set; } = new();
    }
}
