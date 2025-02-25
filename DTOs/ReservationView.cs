﻿namespace UrFUCoworkingsModels.DTOs
{
    public class ReservationView
    {
        public Guid ReservationId { get; set; }
        public string ReservatorName { get; set; }
        public string ReservationBegin { get; set; }
        public string ReservationEnd { get; set; }
        public List<string> Visitors { get; set; }
        public List<Guid> Places { get; set; }
    }
}
