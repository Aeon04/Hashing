using Microsoft.EntityFrameworkCore;
using Hashing.Models;

namespace Hashing.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd()
                    .UseIdentityColumn();
                entity.Property(e => e.Name).HasColumnName("Name").HasMaxLength(50);
                entity.Property(e => e.Username).HasColumnName("Usernames").HasMaxLength(50);
                entity.Property(e => e.Password).HasColumnName("Password");
            });
        }
    }
}
