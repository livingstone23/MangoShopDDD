using MangoShop.Api.Commands.WhatsappMessage;
using MangoShop.Api.Queries.WhatsappMessage;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace MangoShop.Api.Controllers;



[Route("api/[controller]")]
[ApiController]
public class WhatsAppMessagesController : ControllerBase
{
    private readonly IMediator _mediator;

    public WhatsAppMessagesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateWhatsappMessageCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var message = await _mediator.Send(new GetWhatsappMessageByIdQuery { Id = id });
        if (message == null)
            return NotFound();

        return Ok(message);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateWhatsAppMessageCommand command)
    {
        if (id != command.Oui)
            return BadRequest();

        await _mediator.Send(command);
        return NoContent();
    }
}
