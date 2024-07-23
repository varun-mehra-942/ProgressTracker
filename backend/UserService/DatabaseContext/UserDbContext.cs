using Entities;
using Microsoft.EntityFrameworkCore;

namespace DatabaseContext
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
new User() { UserName = "Varun", UserId = Guid.NewGuid(), UserEmail = "varun@admin" }
                );
        }

    }
}

