using Control14.Application.DTOs;
using Control14.Application.PersonalRecords.Commands.CreatePersonalRecord;
using Control14.Application.PersonalRecords.Commands.DeletePersonalRecord;
using Control14.Application.PersonalRecords.Commands.UpdatePersonalRecord;
using Control14.Application.PersonalRecords.Queries.GetAllPersonalRecords;
using Control14.Application.PersonalRecords.Queries.GetPersonalRecordById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Control14.Api.Controllers;

[ApiController]
[Route("api/v1")]
public class PersonalController : ControllerBase
{
    private readonly ISender _sender;

    public PersonalController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("personal-records")]
    [ProducesResponseType(typeof(IEnumerable<PersonalRecordDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var records = await _sender.Send(new GetAllPersonalRecordsQuery(), cancellationToken);
        return Ok(records);
    }

    [HttpGet("personal-record/{id:guid}")]
    [ProducesResponseType(typeof(PersonalRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var record = await _sender.Send(new GetPersonalRecordByIdQuery(id), cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpPost("personal-records")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreatePersonalRecordCommand command, CancellationToken cancellationToken)
    {
        var id = await _sender.Send(command, cancellationToken);

        Response.Headers.Append("X-PersonalRecord-Id", id.ToString());

        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpPut("personal-record/{id:guid}")]
    [ProducesResponseType(typeof(PersonalRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdatePersonalRecordCommand command, CancellationToken cancellationToken)
    {
        var updatedCommand = command with { Id = id };
        var record = await _sender.Send(updatedCommand, cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpDelete("personal-record/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new DeletePersonalRecordCommand(id), cancellationToken);

        if (!result)
            return NotFound();

        return NoContent();
    }
}
