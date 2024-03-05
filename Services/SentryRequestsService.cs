using SeatSentry.Data;
using SeatSentry.DTOs.SentryRequest;
using SeatSentry.Models;

namespace SeatSentry.Services;

public class SentryRequestsService(SeatSentryContext context): ISentryRequestsService
{
    private readonly SeatSentryContext _context = context;

    public IEnumerable<SentryRequest> FindAll()
    {
        throw new NotImplementedException();
    }

    public SentryRequest FindById(Guid id)
    {
        throw new NotImplementedException();
    }

    public SentryRequest Create(NewSentryRequest newSentryRequest)
    {
        throw new NotImplementedException();
    }

    public SentryRequest Update(Guid id, NewSentryRequest newSentryRequest)
    {
        throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}