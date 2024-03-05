using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SeatSentry.Data;
using SeatSentry.Services;

namespace SeatSentry.Controllers;

[ApiController]
[Route("[controller]")]
public class SentryRequestsController(SentryRequestService service) : ControllerBase
{
    private readonly SentryRequestService _service = service;

    [HttpGet]
    public Ok<string> FindAll()
    {
        // TODO: implement this using the service
        return TypedResults.Ok("Hello World");
    }
    
    [HttpGet("{id:guid}")]
    public Ok<string> FindById(Guid id)
    {
        return TypedResults.Ok("Hello World");
    }
    
    [HttpPost]
    public Created<string> Create()
    {
        return TypedResults.Created("/notifications/1", "Hello World");
    }
    
    [HttpPut("{id:guid}")]
    public Ok<string> Update(Guid id)
    {
        return TypedResults.Ok("Hello World");
    }
}