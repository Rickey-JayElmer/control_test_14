namespace Control14.Application.DTOs;

public record GeolocationRecordDto(
    Guid Id,
    string LocationData,
    string GpsReading,
    string HomeLocationArea,
    string CheckinPlace,
    double Latitude,
    string LocationHistoryTrail,
    string GeofenceEntryEvent,
    string RegionCode);
