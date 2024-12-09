namespace UrFUCoworkingsModels.DTOs
{
    public class PlaceDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsWorking { get; set; }
        public int ReservationsCount { get; set; }
    }
}
