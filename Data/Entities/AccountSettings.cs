namespace UrFUCoworkingsModels.Data.Entities
{
    public class AccountSettings
    {
        public Guid Id { get; set; }
        public Guid AccountId { get; set; }
        public virtual Account Account { get; set; } 
        public virtual List<NotificationSettings> NotificationsSettings { get; set; }
        public int DestionatonMessageSystem { get; set; }
        public List<string> MessageSystemsAddreses { get; set; }
    }
}
