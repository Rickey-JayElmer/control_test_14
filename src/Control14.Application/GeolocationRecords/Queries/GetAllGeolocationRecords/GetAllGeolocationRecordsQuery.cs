using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.GeolocationRecords.Queries.GetAllGeolocationRecords;

public record GetAllGeolocationRecordsQuery() : IRequest<IEnumerable<GeolocationRecordDto>>;
