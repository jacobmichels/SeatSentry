using SeatSentry.Data;
using SeatSentry.DTOs.SentryRequests;

namespace SeatSentry.Services;

public class SentryRequestService(SeatSentryContext context)
{
    private readonly SeatSentryContext _context = context;
}