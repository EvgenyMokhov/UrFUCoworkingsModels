namespace UrFUCoworkingsModels.DTOs
{
    public class CSDTO
    {
        public Guid Id { get; set; }
        public DateOnly Day { get; set; }
        public TimeOnly Opening { get; set; }
        public TimeOnly Closing { get; set; }
        public bool IsWorking { get; set; }
    }
}
