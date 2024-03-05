using SeatSentry.DTOs.SentryRequest;
using SeatSentry.Models;

namespace SeatSentry.Services;

public interface ISentryRequestsService
{
    public IEnumerable<SentryRequest> FindAll();
    public SentryRequest FindById(Guid id);
    public SentryRequest Create(NewSentryRequest newSentryRequest);
    public SentryRequest Update(Guid id, NewSentryRequest updateSentryRequest);
    public void Delete(Guid id);
}