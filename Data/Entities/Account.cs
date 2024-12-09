namespace UrFUCoworkingsModels.Data.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public virtual AccountSettings Settings { get; set; }
    }
}
