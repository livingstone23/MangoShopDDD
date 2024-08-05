using MangoShop.Api.Commands.Client;
using MangoShop.Api.Queries.Client;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;



namespace MangoShop.Api.Controllers;



[Route("api/[controller]")]
[ApiController]
public class ClientsController : ControllerBase
{


    private readonly IMediator _mediator;


    public ClientsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateClientCommand command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var client = await _mediator.Send(new GetClientByIdQuery { Id = id });
        if (client == null)
            return NotFound();

        return Ok(client);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateClientCommand command)
    {
        if (id != command.Id)
            return BadRequest();

        await _mediator.Send(command);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _mediator.Send(new DeleteClientCommand { Id = id });
        return NoContent();
    }

}
