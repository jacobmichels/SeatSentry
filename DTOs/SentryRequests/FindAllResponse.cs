using SeatSentry.Models;

namespace SeatSentry.DTOs.SentryRequests;

public class FindAllResponse
{
    // TODO: I probably don't want to be returning the entire SentryRequest object
    public IList<SentryRequest> SentryRequests { get; set; }
}