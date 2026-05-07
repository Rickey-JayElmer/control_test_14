using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.HrRecords.Queries.GetAllHrRecords;

public record GetAllHrRecordsQuery() : IRequest<IEnumerable<HrRecordDto>>;
