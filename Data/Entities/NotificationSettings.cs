namespace UrFUCoworkingsModels.Data.Entities
{
    public class NotificationSettings
    {
        public Guid Id { get; set; }
        public int NotificationType { get; set; }
        public bool IsNeedsSend { get; set; }
        public int TimeSetting { get; set; }
        public Guid AccountSettingsId { get; set; }
        public virtual AccountSettings AccountSettings { get; set; }
    }
}
