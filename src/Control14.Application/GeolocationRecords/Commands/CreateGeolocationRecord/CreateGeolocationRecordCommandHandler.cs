using Control14.Application.Interfaces;
using Control14.Domain.Entities;
using MediatR;

namespace Control14.Application.GeolocationRecords.Commands.CreateGeolocationRecord;

public class CreateGeolocationRecordCommandHandler : IRequestHandler<CreateGeolocationRecordCommand, Guid>
{
    private readonly IGeolocationRecordRepository _repository;

    public CreateGeolocationRecordCommandHandler(IGeolocationRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateGeolocationRecordCommand request, CancellationToken cancellationToken)
    {
        var record = GeolocationRecord.Create(
            request.LocationData,
            request.GpsReading,
            request.HomeLocationArea,
            request.CheckinPlace,
            request.Latitude,
            request.LocationHistoryTrail,
            request.GeofenceEntryEvent,
            request.RegionCode);

        await _repository.AddAsync(record, cancellationToken);

        return record.Id;
    }
}
