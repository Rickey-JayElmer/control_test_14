using MediatR;

namespace Control14.Application.GeolocationRecords.Commands.CreateGeolocationRecord;

public record CreateGeolocationRecordCommand(
    string LocationData,
    string GpsReading,
    string HomeLocationArea,
    string CheckinPlace,
    double Latitude,
    string LocationHistoryTrail,
    string GeofenceEntryEvent,
    string RegionCode) : IRequest<Guid>;
