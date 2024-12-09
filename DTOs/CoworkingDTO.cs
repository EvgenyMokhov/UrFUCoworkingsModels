namespace UrFUCoworkingsModels.DTOs
{
    public class CoworkingDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public TimeOnly Opening { get; set; }
        public TimeOnly Closing { get; set; }
        public List<ZoneDTO> Zones { get; set; }
        public List<CSDTO> Settings { get; set; }
        public bool IsWorking { get; set; }
    }
}
