using apigateway.Dtos.TransportOptions;
using Microsoft.AspNetCore.Mvc;

namespace apigateway.Controllers;

[ApiController]
[Route("[controller]")]
public class TransportOptionsController : ControllerBase
{
    private readonly ILogger<TransportOptionsController> _logger;

    public TransportOptionsController(ILogger<TransportOptionsController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "GetTransportOptions")]
    public IEnumerable<TransportOption> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new TransportOption()
            {
                
            })
            .ToArray();
    }
    
    [HttpPost(Name = "PostTransportOption")]
    public TransportOption Post(TransportOptionCreate transportOptionCreate)
    {
        return new TransportOption()
        {

        };
    }
    
    [HttpGet("{id}", Name = "GetTransportOption")]
    public TransportOption Get(Guid id, DateTime? fromTimeStamp)
    {
        return new TransportOption()
        {

        };
    }
    
    [HttpPost("{id}/Discount", Name = "PostTransportOptionDiscount")]
    public void PostTransportOptionDiscount(Guid id, TransportOptionDiscount transportOptionDiscount)
    {
        
    }
}