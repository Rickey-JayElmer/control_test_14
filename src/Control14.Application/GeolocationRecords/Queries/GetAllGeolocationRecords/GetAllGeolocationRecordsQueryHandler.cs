using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.GeolocationRecords.Queries.GetAllGeolocationRecords;

public class GetAllGeolocationRecordsQueryHandler : IRequestHandler<GetAllGeolocationRecordsQuery, IEnumerable<GeolocationRecordDto>>
{
    private readonly IGeolocationRecordRepository _repository;

    public GetAllGeolocationRecordsQueryHandler(IGeolocationRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<GeolocationRecordDto>> Handle(GetAllGeolocationRecordsQuery request, CancellationToken cancellationToken)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        return records.Select(r => r.ToDto());
    }
}
