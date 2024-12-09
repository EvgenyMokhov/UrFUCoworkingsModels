using Microsoft.EntityFrameworkCore;
using UrFUCoworkingsModels.Data.Entities;
using UrFUCoworkingsModels.Data.Entities;

namespace UrFUCoworkingsModels.Data
{
    public class EFDBContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Visit> Visits { get; set; } = null!;
        public DbSet<Reservation> Reservations { get; set; } = null!;
        public DbSet<Place> Places { get; set; } = null!;
        public DbSet<Coworking> Coworkings { get; set; } = null!;
        public DbSet<CoworkingSettings> CoworkingSettings { get; set; } = null!;
        public DbSet<Zone> Zones { get; set; } = null!;
        public DbSet<Account> Accounts { get; set; } = null!;
        public DbSet<AccountSettings> AccountSettings { get; set; } = null!;
        public DbSet<NotificationSettings> NotificationSettings { get; set; } = null!;
        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies();
        }
    }
}
