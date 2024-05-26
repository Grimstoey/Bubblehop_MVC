using BubblehopWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BubblehopWeb.Data
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


            //Many-To-Many
            modelBuilder.Entity<UserTravelPlan>()
                .HasKey(utp => new { utp.UserId, utp.TravelPlanId });

            modelBuilder.Entity<UserTravelPlan>()
                .HasOne(utp => utp.User)
                .WithMany(many => many.UserTravelPlans)
                .HasForeignKey(fKey => fKey.TravelPlanId);

            modelBuilder.Entity<UserTravelPlan>()
                .HasOne(utp => utp.TravelPlan)
                .WithMany(many => many.UserTravelPlans)
                .HasForeignKey(fKey => fKey.UserId);
        }
    }
}
