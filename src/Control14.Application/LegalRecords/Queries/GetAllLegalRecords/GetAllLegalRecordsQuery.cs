using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.LegalRecords.Queries.GetAllLegalRecords;

public record GetAllLegalRecordsQuery() : IRequest<IEnumerable<LegalRecordDto>>;
