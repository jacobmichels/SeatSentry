namespace SeatSentry.Models;

public class SentryRequest
{
    public Guid Id { get; set; }
    public User User { get; set; }
    public Section Section { get; set; }
}