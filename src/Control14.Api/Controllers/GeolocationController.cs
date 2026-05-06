using Control14.Application.DTOs;
using Control14.Application.GeolocationRecords.Commands.CreateGeolocationRecord;
using Control14.Application.GeolocationRecords.Commands.DeleteGeolocationRecord;
using Control14.Application.GeolocationRecords.Commands.UpdateGeolocationRecord;
using Control14.Application.GeolocationRecords.Queries.GetAllGeolocationRecords;
using Control14.Application.GeolocationRecords.Queries.GetGeolocationRecordById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Control14.Api.Controllers;

[ApiController]
[Route("api/v1")]
public class GeolocationController : ControllerBase
{
    private readonly ISender _sender;

    public GeolocationController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("geolocation-records")]
    [ProducesResponseType(typeof(IEnumerable<GeolocationRecordDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var records = await _sender.Send(new GetAllGeolocationRecordsQuery(), cancellationToken);
        return Ok(records);
    }

    [HttpGet("geolocation-record/{id:guid}")]
    [ProducesResponseType(typeof(GeolocationRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var record = await _sender.Send(new GetGeolocationRecordByIdQuery(id), cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpPost("geolocation-records")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateGeolocationRecordCommand command, CancellationToken cancellationToken)
    {
        var id = await _sender.Send(command, cancellationToken);

        Response.Headers.Append("X-GeolocationRecord-Id", id.ToString());

        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpPut("geolocation-record/{id:guid}")]
    [ProducesResponseType(typeof(GeolocationRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateGeolocationRecordCommand command, CancellationToken cancellationToken)
    {
        var updatedCommand = command with { Id = id };
        var record = await _sender.Send(updatedCommand, cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpDelete("geolocation-record/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new DeleteGeolocationRecordCommand(id), cancellationToken);

        if (!result)
            return NotFound();

        return NoContent();
    }
}
