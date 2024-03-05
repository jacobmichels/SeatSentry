using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SeatSentry.Data;

namespace SeatSentry.Controllers;

[ApiController]
[Route("[controller]")]
public class SentryRequestsController(SeatSentryContext context) : ControllerBase
{
    private readonly SeatSentryContext _context = context;

    [HttpGet]
    public Ok<string> FindAll()
    {
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