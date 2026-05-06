using Control14.Application.DTOs;
using Control14.Application.NetworkRequestRecords.Commands.CreateNetworkRequestRecord;
using Control14.Application.NetworkRequestRecords.Commands.DeleteNetworkRequestRecord;
using Control14.Application.NetworkRequestRecords.Commands.UpdateNetworkRequestRecord;
using Control14.Application.NetworkRequestRecords.Queries.GetAllNetworkRequestRecords;
using Control14.Application.NetworkRequestRecords.Queries.GetNetworkRequestRecordById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Control14.Api.Controllers;

[ApiController]
[Route("api/v1")]
public class NetworkController : ControllerBase
{
    private readonly ISender _sender;

    public NetworkController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("network-requests")]
    [ProducesResponseType(typeof(IEnumerable<NetworkRequestRecordDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var records = await _sender.Send(new GetAllNetworkRequestRecordsQuery(), cancellationToken);
        return Ok(records);
    }

    [HttpGet("network-request/{id:guid}")]
    [ProducesResponseType(typeof(NetworkRequestRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var record = await _sender.Send(new GetNetworkRequestRecordByIdQuery(id), cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpPost("network-requests")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateNetworkRequestRecordCommand command, CancellationToken cancellationToken)
    {
        var id = await _sender.Send(command, cancellationToken);

        Response.Headers.Append("X-NetworkRequestRecord-Id", id.ToString());

        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpPut("network-request/{id:guid}")]
    [ProducesResponseType(typeof(NetworkRequestRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateNetworkRequestRecordCommand command, CancellationToken cancellationToken)
    {
        var updatedCommand = command with { Id = id };
        var record = await _sender.Send(updatedCommand, cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpDelete("network-request/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new DeleteNetworkRequestRecordCommand(id), cancellationToken);

        if (!result)
            return NotFound();

        return NoContent();
    }
}
