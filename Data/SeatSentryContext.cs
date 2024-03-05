using Microsoft.EntityFrameworkCore;
using SeatSentry.Models;

namespace SeatSentry.Data;

public class SeatSentryContext: DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<SentryRequest> SentryRequests { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Course> Courses { get; set; }
    
    public SeatSentryContext(DbContextOptions<SeatSentryContext> options): base(options)
    {
    }
}