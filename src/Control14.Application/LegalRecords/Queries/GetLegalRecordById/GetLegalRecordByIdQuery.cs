using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.LegalRecords.Queries.GetLegalRecordById;

public record GetLegalRecordByIdQuery(Guid Id) : IRequest<LegalRecordDto?>;
