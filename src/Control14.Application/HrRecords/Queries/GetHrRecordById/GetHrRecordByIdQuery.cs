using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.HrRecords.Queries.GetHrRecordById;

public record GetHrRecordByIdQuery(Guid Id) : IRequest<HrRecordDto?>;
