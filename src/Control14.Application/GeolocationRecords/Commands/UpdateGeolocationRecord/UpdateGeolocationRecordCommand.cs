using System.Text.Json.Serialization;
using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.GeolocationRecords.Commands.UpdateGeolocationRecord;

public record UpdateGeolocationRecordCommand(
    Guid Id,
    [property: JsonPropertyName("location_data")] string LocationData,
    [property: JsonPropertyName("gps_reading")] string GpsReading,
    [property: JsonPropertyName("home_location_area")] string HomeLocationArea,
    [property: JsonPropertyName("checkin_place")] string CheckinPlace,
    [property: JsonPropertyName("latitude")] double Latitude,
    [property: JsonPropertyName("location_history_trail")] string LocationHistoryTrail,
    [property: JsonPropertyName("geofence_entry_event")] string GeofenceEntryEvent,
    [property: JsonPropertyName("region_code")] string RegionCode,
    [property: JsonPropertyName("user_gps_lat")] double UserGpsLat) : IRequest<GeolocationRecordDto?>;
