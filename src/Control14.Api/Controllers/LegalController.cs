using Control14.Application.DTOs;
using Control14.Application.LegalRecords.Commands.CreateLegalRecord;
using Control14.Application.LegalRecords.Commands.DeleteLegalRecord;
using Control14.Application.LegalRecords.Commands.UpdateLegalRecord;
using Control14.Application.LegalRecords.Queries.GetAllLegalRecords;
using Control14.Application.LegalRecords.Queries.GetLegalRecordById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Control14.Api.Controllers;

[ApiController]
[Route("api/v1")]
public class LegalController : ControllerBase
{
    private readonly ISender _sender;

    public LegalController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("legal-records")]
    [ProducesResponseType(typeof(IEnumerable<LegalRecordDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var records = await _sender.Send(new GetAllLegalRecordsQuery(), cancellationToken);
        return Ok(records);
    }

    [HttpGet("legal-record/{id:guid}")]
    [ProducesResponseType(typeof(LegalRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var record = await _sender.Send(new GetLegalRecordByIdQuery(id), cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpPost("legal-records")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateLegalRecordCommand command, CancellationToken cancellationToken)
    {
        var id = await _sender.Send(command, cancellationToken);

        Response.Headers.Append("X-LegalRecord-Id", id.ToString());

        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpPut("legal-record/{id:guid}")]
    [ProducesResponseType(typeof(LegalRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateLegalRecordCommand command, CancellationToken cancellationToken)
    {
        var updatedCommand = command with { Id = id };
        var record = await _sender.Send(updatedCommand, cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpDelete("legal-record/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new DeleteLegalRecordCommand(id), cancellationToken);

        if (!result)
            return NotFound();

        return NoContent();
    }
}
