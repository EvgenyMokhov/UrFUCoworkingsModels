namespace UrFUCoworkingsModels.Data.Entities
{
    public class Zone
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual List<Place> Places { get; set; } = null!;
        public Guid CoworkingId { get; set; }
        public virtual Coworking Coworking { get; set; } = null!;
        public bool IsWorking { get; set; }
    }
}
