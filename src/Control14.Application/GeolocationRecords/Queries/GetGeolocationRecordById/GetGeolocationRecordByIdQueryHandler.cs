using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.GeolocationRecords.Queries.GetGeolocationRecordById;

public class GetGeolocationRecordByIdQueryHandler : IRequestHandler<GetGeolocationRecordByIdQuery, GeolocationRecordDto?>
{
    private readonly IGeolocationRecordRepository _repository;

    public GetGeolocationRecordByIdQueryHandler(IGeolocationRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<GeolocationRecordDto?> Handle(GetGeolocationRecordByIdQuery request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);
        return record?.ToDto();
    }
}
