using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.SecurityRecords.Queries.GetAllSecurityRecords;

public record GetAllSecurityRecordsQuery() : IRequest<IEnumerable<SecurityRecordDto>>;
