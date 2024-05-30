using Bubblehop.Models;
using Microsoft.EntityFrameworkCore;

namespace Bubblehop.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<TravelPlan> TravelPlans { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<UserTravelPlan> UserTravelPlans { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // Configure many-to-many relationship for UserTravelPlan
            modelBuilder.Entity<UserTravelPlan>()
                .HasKey(utp => new { utp.UserId, utp.TravelPlanId });


            modelBuilder.Entity<UserTravelPlan>()
                .HasOne(utp => utp.User)
                .WithMany(many => many.UserTravelPlans)
                .HasForeignKey(fKey => fKey.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Disable cascade delete ปิดการใช้งานการลบแบบเรียงซ้อน


            modelBuilder.Entity<UserTravelPlan>()
                .HasOne(utp => utp.TravelPlan)
                .WithMany(many => many.UserTravelPlans)
                .HasForeignKey(fKey => fKey.TravelPlanId)
                .OnDelete(DeleteBehavior.Restrict); // Disable cascade delete
        }
    }
}
