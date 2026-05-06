using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.GeolocationRecords.Queries.GetGeolocationRecordById;

public record GetGeolocationRecordByIdQuery(Guid Id) : IRequest<GeolocationRecordDto?>;
