using Control14.Application.DTOs;
using Control14.Application.HrRecords.Commands.CreateHrRecord;
using Control14.Application.HrRecords.Commands.DeleteHrRecord;
using Control14.Application.HrRecords.Commands.UpdateHrRecord;
using Control14.Application.HrRecords.Queries.GetAllHrRecords;
using Control14.Application.HrRecords.Queries.GetHrRecordById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Control14.Api.Controllers;

[ApiController]
[Route("api/v1")]
public class HrController : ControllerBase
{
    private readonly ISender _sender;

    public HrController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("hr-records")]
    [ProducesResponseType(typeof(IEnumerable<HrRecordDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var records = await _sender.Send(new GetAllHrRecordsQuery(), cancellationToken);
        return Ok(records);
    }

    [HttpGet("hr-record/{id:guid}")]
    [ProducesResponseType(typeof(HrRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var record = await _sender.Send(new GetHrRecordByIdQuery(id), cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpPost("hr-records")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateHrRecordCommand command, CancellationToken cancellationToken)
    {
        var id = await _sender.Send(command, cancellationToken);

        Response.Headers.Append("X-HrRecord-Id", id.ToString());

        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpPut("hr-record/{id:guid}")]
    [ProducesResponseType(typeof(HrRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateHrRecordCommand command, CancellationToken cancellationToken)
    {
        var updatedCommand = command with { Id = id };
        var record = await _sender.Send(updatedCommand, cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpDelete("hr-record/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new DeleteHrRecordCommand(id), cancellationToken);

        if (!result)
            return NotFound();

        return NoContent();
    }
}
