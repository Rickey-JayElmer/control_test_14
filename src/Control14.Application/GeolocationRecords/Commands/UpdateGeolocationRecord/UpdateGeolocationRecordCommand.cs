using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.GeolocationRecords.Commands.UpdateGeolocationRecord;

public record UpdateGeolocationRecordCommand(
    Guid Id,
    string LocationData,
    string GpsReading,
    string HomeLocationArea,
    string CheckinPlace,
    double Latitude,
    string LocationHistoryTrail,
    string GeofenceEntryEvent,
    string RegionCode) : IRequest<GeolocationRecordDto?>;
