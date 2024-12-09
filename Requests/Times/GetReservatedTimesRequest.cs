using UrFUCoworkingsModels.DTOs;

namespace UrFUCoworkingsModels.Requests.Times
{
    public class GetReservatedTimesRequest
    {
        public Guid PlaceId { get; set; }
        public DateOnly Date { get; set; }
        public CSDTO Setting { get; set; }
    }
}
