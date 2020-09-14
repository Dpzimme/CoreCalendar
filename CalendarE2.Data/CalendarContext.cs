using Microsoft.EntityFrameworkCore;
using System;
using CalendarE2.Domain;

namespace CalendarE2.Data
{
    public class CalendarContext : DbContext
    {
        public DbSet<MyEvent> Events { get; set; }
        public DbSet<AdminLevel> AdminLevels { get; set; }
        public DbSet<CalendarUser> Users { get; set; }

        public CalendarContext(DbContextOptions<CalendarContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var al0 = new AdminLevel() { AdminLevelId = 1, AdminLevelDesignation = 0, Description = "basic user, cannot see calendar of other users" };
            var al1 = new AdminLevel() { AdminLevelId = 2, AdminLevelDesignation = 1, Description = "can see my own and the calendar of other users with adminLevel = 0" };
            var al2 = new AdminLevel() { AdminLevelId = 3, AdminLevelDesignation = 2, Description = "Can see my own the calendar of other users with adminLevels 0, 1" };
            var al3 = new AdminLevel() { AdminLevelId = 4, AdminLevelDesignation = 3, Description = "Can see the calendar of any user" };
            modelBuilder.Entity<AdminLevel>().HasData(
                   al0, al1, al2, al3
                );

            modelBuilder.Entity<CalendarUser>().HasData(
             new CalendarUser() { UserId = 1, Name = "Bill Jones", Description = "Solid Data Viz Analyst", AdminLevelId = 1 },
            new CalendarUser() { UserId = 2, Name = "Bill Evans", Description = "The master ", AdminLevelId = 2 },
            new CalendarUser() { UserId = 3, Name = "Rex Stone", Description = "OG Visionary ", AdminLevelId = 3 },
            new CalendarUser() { UserId = 4, Name = "Regent Phil", Description = "Whatever happens", AdminLevelId = 3 },
            new CalendarUser() { UserId = 5, Name = "DZ", Description = "DZ", AdminLevelId = 4 },
             new CalendarUser() { UserId = 6, Name = "admin", Description = "admin top admin", AdminLevelId = 4 }
            );

            modelBuilder.Entity<MyEvent>().HasData(

            new MyEvent()
            {
                id = 1,
                Title = "Lunch with Veronica",
                Description = "Lots of great stuff",
                UserId = 1,
                DateHour = new DateTime(2020, 8, 12, 12, 0, 0)
            },
            new MyEvent()
            {
                id = 2,
                Title = "meeting with Steve",
                Description = "More and More ",
                UserId = 1,
                DateHour = new DateTime(2020, 8, 12, 11, 0, 0)
            },
            new MyEvent()
            {
                id = 3,
                Title = "Project Review with David",
                Description = "Check the progress",
                UserId = 2,               
                DateHour = new DateTime(2020, 8, 13, 13, 0, 0)
            },
            new MyEvent()
            {
                id = 4,
                Title = "Meeting on Day 2",
                Description = "Lots of stuff",
                UserId = 2,                
                DateHour = new DateTime(2020, 8, 13, 11, 0, 0)
            }); 

        }

    }
}
