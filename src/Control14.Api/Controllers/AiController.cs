using Control14.Application.DTOs;
using Control14.Application.AiInferenceRecords.Commands.CreateAiInferenceRecord;
using Control14.Application.AiInferenceRecords.Commands.DeleteAiInferenceRecord;
using Control14.Application.AiInferenceRecords.Commands.UpdateAiInferenceRecord;
using Control14.Application.AiInferenceRecords.Queries.GetAllAiInferenceRecords;
using Control14.Application.AiInferenceRecords.Queries.GetAiInferenceRecordById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Control14.Api.Controllers;

[ApiController]
[Route("api/v1")]
public class AiController : ControllerBase
{
    private readonly ISender _sender;

    public AiController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("ai-records")]
    [ProducesResponseType(typeof(IEnumerable<AiInferenceRecordDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var records = await _sender.Send(new GetAllAiInferenceRecordsQuery(), cancellationToken);
        return Ok(records);
    }

    [HttpGet("ai-record/{id:guid}")]
    [ProducesResponseType(typeof(AiInferenceRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var record = await _sender.Send(new GetAiInferenceRecordByIdQuery(id), cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpPost("ai-records")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateAiInferenceRecordCommand command, CancellationToken cancellationToken)
    {
        var id = await _sender.Send(command, cancellationToken);

        Response.Headers.Append("X-AiInferenceRecord-Id", id.ToString());

        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpPut("ai-record/{id:guid}")]
    [ProducesResponseType(typeof(AiInferenceRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateAiInferenceRecordCommand command, CancellationToken cancellationToken)
    {
        var updatedCommand = command with { Id = id };
        var record = await _sender.Send(updatedCommand, cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpDelete("ai-record/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new DeleteAiInferenceRecordCommand(id), cancellationToken);

        if (!result)
            return NotFound();

        return NoContent();
    }
}
