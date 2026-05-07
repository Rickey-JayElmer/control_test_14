using Control14.Application.DTOs;
using Control14.Application.OrganizationRecords.Commands.CreateOrganizationRecord;
using Control14.Application.OrganizationRecords.Commands.DeleteOrganizationRecord;
using Control14.Application.OrganizationRecords.Commands.UpdateOrganizationRecord;
using Control14.Application.OrganizationRecords.Queries.GetAllOrganizationRecords;
using Control14.Application.OrganizationRecords.Queries.GetOrganizationRecordById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Control14.Api.Controllers;

[ApiController]
[Route("api/v1")]
public class OrganizationController : ControllerBase
{
    private readonly ISender _sender;

    public OrganizationController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("organization-records")]
    [ProducesResponseType(typeof(IEnumerable<OrganizationRecordDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var records = await _sender.Send(new GetAllOrganizationRecordsQuery(), cancellationToken);
        return Ok(records);
    }

    [HttpGet("organization-record/{id:guid}")]
    [ProducesResponseType(typeof(OrganizationRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var record = await _sender.Send(new GetOrganizationRecordByIdQuery(id), cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpPost("organization-records")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateOrganizationRecordCommand command, CancellationToken cancellationToken)
    {
        var id = await _sender.Send(command, cancellationToken);

        Response.Headers.Append("X-OrganizationRecord-Id", id.ToString());

        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpPut("organization-record/{id:guid}")]
    [ProducesResponseType(typeof(OrganizationRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateOrganizationRecordCommand command, CancellationToken cancellationToken)
    {
        var updatedCommand = command with { Id = id };
        var record = await _sender.Send(updatedCommand, cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpDelete("organization-record/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new DeleteOrganizationRecordCommand(id), cancellationToken);

        if (!result)
            return NotFound();

        return NoContent();
    }
}
