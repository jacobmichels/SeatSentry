using Microsoft.EntityFrameworkCore;
using SeatSentry.Models;

namespace SeatSentry.Data;

public class AppDbContext: DbContext
{
    public DbSet<User> Users { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}