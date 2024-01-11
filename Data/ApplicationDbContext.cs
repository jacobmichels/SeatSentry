using Microsoft.EntityFrameworkCore;
using SeatSentry.Models;

namespace SeatSentry.Data;

public class ApplicationDbContext: DbContext
{
    public DbSet<CourseNotification> CourseNotifications { get; set; }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}