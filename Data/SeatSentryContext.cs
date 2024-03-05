using Microsoft.EntityFrameworkCore;
using SeatSentry.Models;

namespace SeatSentry.Data;

public class SeatSentryContext: DbContext
{
    public DbSet<User> Users { get; set; }
    
    public SeatSentryContext(DbContextOptions<SeatSentryContext> options): base(options)
    {
    }
}