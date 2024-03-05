namespace SeatSentry.Models;

public class User
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public IList<SentryRequest> SpaceNotificationRequests { get; init; }
    public string Email { get; init; }
}