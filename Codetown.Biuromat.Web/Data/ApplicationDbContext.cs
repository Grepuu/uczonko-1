using Codetown.Biuromat.Web.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Codetown.Biuromat.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<BuildingEntity> Buildings { get; set; }
        public DbSet<RoomEntity> Rooms { get; set; }
        public DbSet<RoleEntity> AccessRoles { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BuildingEntity>()
                .HasMany(n => n.Rooms)
                .WithOne(n => n.Building);
            
            base.OnModelCreating(builder);
        }
        
        
    }
}