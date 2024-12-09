namespace UrFUCoworkingsModels.DTOs
{
    public class ZoneDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<PlaceDTO> Places { get; set; }
        public bool IsWorking { get; set; }
    }
}
