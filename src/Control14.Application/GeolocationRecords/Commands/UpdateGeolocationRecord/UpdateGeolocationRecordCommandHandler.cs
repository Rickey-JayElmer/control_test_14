using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.GeolocationRecords.Commands.UpdateGeolocationRecord;

public class UpdateGeolocationRecordCommandHandler : IRequestHandler<UpdateGeolocationRecordCommand, GeolocationRecordDto?>
{
    private readonly IGeolocationRecordRepository _repository;

    public UpdateGeolocationRecordCommandHandler(IGeolocationRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<GeolocationRecordDto?> Handle(UpdateGeolocationRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return null;

        record.Update(
            request.LocationData,
            request.GpsReading,
            request.HomeLocationArea,
            request.CheckinPlace,
            request.Latitude,
            request.LocationHistoryTrail,
            request.GeofenceEntryEvent,
            request.RegionCode);

        await _repository.UpdateAsync(record, cancellationToken);

        return record.ToDto();
    }
}
