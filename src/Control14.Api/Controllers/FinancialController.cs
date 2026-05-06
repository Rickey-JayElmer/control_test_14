using Control14.Application.DTOs;
using Control14.Application.FinancialPaymentRecords.Commands.CreateFinancialPaymentRecord;
using Control14.Application.FinancialPaymentRecords.Commands.DeleteFinancialPaymentRecord;
using Control14.Application.FinancialPaymentRecords.Commands.UpdateFinancialPaymentRecord;
using Control14.Application.FinancialPaymentRecords.Queries.GetAllFinancialPaymentRecords;
using Control14.Application.FinancialPaymentRecords.Queries.GetFinancialPaymentRecordById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Control14.Api.Controllers;

[ApiController]
[Route("api/v1")]
public class FinancialController : ControllerBase
{
    private readonly ISender _sender;

    public FinancialController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet("financial-payments")]
    [ProducesResponseType(typeof(IEnumerable<FinancialPaymentRecordDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var records = await _sender.Send(new GetAllFinancialPaymentRecordsQuery(), cancellationToken);
        return Ok(records);
    }

    [HttpGet("financial-payment/{id:guid}")]
    [ProducesResponseType(typeof(FinancialPaymentRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var record = await _sender.Send(new GetFinancialPaymentRecordByIdQuery(id), cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpPost("financial-payments")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<IActionResult> Create([FromBody] CreateFinancialPaymentRecordCommand command, CancellationToken cancellationToken)
    {
        var id = await _sender.Send(command, cancellationToken);

        Response.Headers.Append("X-FinancialPaymentRecord-Id", id.ToString());

        return CreatedAtAction(nameof(GetById), new { id }, null);
    }

    [HttpPut("financial-payment/{id:guid}")]
    [ProducesResponseType(typeof(FinancialPaymentRecordDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateFinancialPaymentRecordCommand command, CancellationToken cancellationToken)
    {
        var updatedCommand = command with { Id = id };
        var record = await _sender.Send(updatedCommand, cancellationToken);

        if (record is null)
            return NotFound();

        return Ok(record);
    }

    [HttpDelete("financial-payment/{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
    {
        var result = await _sender.Send(new DeleteFinancialPaymentRecordCommand(id), cancellationToken);

        if (!result)
            return NotFound();

        return NoContent();
    }
}
