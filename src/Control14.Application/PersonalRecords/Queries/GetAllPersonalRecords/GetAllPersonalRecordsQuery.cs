using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.PersonalRecords.Queries.GetAllPersonalRecords;

public record GetAllPersonalRecordsQuery() : IRequest<IEnumerable<PersonalRecordDto>>;
