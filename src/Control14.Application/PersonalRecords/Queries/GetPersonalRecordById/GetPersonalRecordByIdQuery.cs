using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.PersonalRecords.Queries.GetPersonalRecordById;

public record GetPersonalRecordByIdQuery(Guid Id) : IRequest<PersonalRecordDto?>;
