namespace UrFUCoworkingsModels.Data.Entities
{
    public class Place
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsWorking { get; set; }
        public virtual List<Reservation> Reservations { get; set; } = new();
        public virtual Zone Zone { get; set; } = null!;
    }
}
