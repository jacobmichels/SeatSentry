namespace SeatSentry.DTOs.SentryRequest;

public class NewSentryRequest
{
    public Guid UserId { get; set; }
    public Guid SectionId { get; set; }
}