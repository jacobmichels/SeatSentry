using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SeatSentry.DTOs.SentryRequest;
using SeatSentry.Models;
using SeatSentry.Services;

namespace SeatSentry.Controllers;

[ApiController]
[Route("[controller]")]
public class SentryRequestsController(ISentryRequestsService service) : ControllerBase
{
    [HttpGet]
    public Ok<IEnumerable<SentryRequest>> FindAll()
    {
        return TypedResults.Ok(service.FindAll());
    }
    
    [HttpGet("{id:guid}")]
    public Ok<SentryRequest> FindById(Guid id)
    {
        return TypedResults.Ok(service.FindById(id));
    }
    
    [HttpPost]
    public Created<SentryRequest> Create([FromBody]NewSentryRequest newSentryRequest)
    {
        var created = service.Create(newSentryRequest);
        return TypedResults.Created($@"/notifications/{created.Id}", created);
    }
    
    [HttpPut("{id:guid}")]
    public Ok<SentryRequest> Update(Guid id, [FromBody]NewSentryRequest newSentryRequest)
    {
        return TypedResults.Ok(service.Update(id, newSentryRequest));
    }
    
    [HttpDelete("{id:guid}")]
    public NoContent Delete(Guid id)
    {
        service.Delete(id);
        return TypedResults.NoContent();
    }
}