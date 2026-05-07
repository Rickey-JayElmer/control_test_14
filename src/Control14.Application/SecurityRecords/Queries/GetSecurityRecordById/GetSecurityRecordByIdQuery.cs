using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.SecurityRecords.Queries.GetSecurityRecordById;

public record GetSecurityRecordByIdQuery(Guid Id) : IRequest<SecurityRecordDto?>;
