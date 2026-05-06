using Control14.Application.DTOs;
using Control14.Application.DeviceTelemetryRecords.Commands.CreateDeviceTelemetryRecord;
using Control14.Application.DeviceTelemetryRecords.Commands.DeleteDeviceTelemetryRecord;
using Control14.Application.DeviceTelemetryRecords.Commands.UpdateDeviceTelemetryRecord;
using Control14.Application.DeviceTelemetryRecords.Queries.GetAllDeviceTelemetryRecords;
using Control14.Application.DeviceTelemetryRecords.Queries.GetDeviceTelemetryRecordById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Control14.Api.Controllers;

[ApiController]
[Route("api/v1")]
public class DeviceController : ControllerBase
{
    private readonly ISender _sender;

    public DeviceController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("device-records")]
    [ProducesResponseType(typeof(IEnumerable<DeviceTelemetryRecordDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var records = await _sender.Send(new GetAllDeviceTelemetryRecordsQuery(), cancellationToken);
        return Ok(records);
    }

    [HttpGet("device-record/{id:guid}")]
    [ProducesResponseType(typeof(DeviceTelemetryRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var record = await _sender.Send(new GetDeviceTelemetryRecordByIdQuery(id), cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpPost("device-records")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateDeviceTelemetryRecordCommand command, CancellationToken cancellationToken)
    {
        var id = await _sender.Send(command, cancellationToken);

        Response.Headers.Append("X-DeviceTelemetryRecord-Id", id.ToString());

        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpPut("device-record/{id:guid}")]
    [ProducesResponseType(typeof(DeviceTelemetryRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateDeviceTelemetryRecordCommand command, CancellationToken cancellationToken)
    {
        var updatedCommand = command with { Id = id };
        var record = await _sender.Send(updatedCommand, cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpDelete("device-record/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new DeleteDeviceTelemetryRecordCommand(id), cancellationToken);

        if (!result)
            return NotFound();

        return NoContent();
    }
}
