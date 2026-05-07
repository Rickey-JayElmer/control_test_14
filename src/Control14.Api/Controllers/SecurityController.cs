using Control14.Application.DTOs;
using Control14.Application.SecurityRecords.Commands.CreateSecurityRecord;
using Control14.Application.SecurityRecords.Commands.DeleteSecurityRecord;
using Control14.Application.SecurityRecords.Commands.UpdateSecurityRecord;
using Control14.Application.SecurityRecords.Queries.GetAllSecurityRecords;
using Control14.Application.SecurityRecords.Queries.GetSecurityRecordById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Control14.Api.Controllers;

[ApiController]
[Route("api/v1")]
public class SecurityController : ControllerBase
{
    private readonly ISender _sender;

    public SecurityController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("security-records")]
    [ProducesResponseType(typeof(IEnumerable<SecurityRecordDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var records = await _sender.Send(new GetAllSecurityRecordsQuery(), cancellationToken);
        return Ok(records);
    }

    [HttpGet("security-record/{id:guid}")]
    [ProducesResponseType(typeof(SecurityRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var record = await _sender.Send(new GetSecurityRecordByIdQuery(id), cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpPost("security-records")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateSecurityRecordCommand command, CancellationToken cancellationToken)
    {
        var id = await _sender.Send(command, cancellationToken);

        Response.Headers.Append("X-SecurityRecord-Id", id.ToString());

        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpPut("security-record/{id:guid}")]
    [ProducesResponseType(typeof(SecurityRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateSecurityRecordCommand command, CancellationToken cancellationToken)
    {
        var updatedCommand = command with { Id = id };
        var record = await _sender.Send(updatedCommand, cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpDelete("security-record/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new DeleteSecurityRecordCommand(id), cancellationToken);

        if (!result)
            return NotFound();

        return NoContent();
    }
}
