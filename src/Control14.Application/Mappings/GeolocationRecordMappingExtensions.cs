using Control14.Application.DTOs;
using Control14.Domain.Entities;

namespace Control14.Application.Mappings;

public static class GeolocationRecordMappingExtensions
{
    public static GeolocationRecordDto ToDto(this GeolocationRecord record)
    {
        return new GeolocationRecordDto(
            record.Id,
            record.LocationData,
            record.GpsReading,
            record.HomeLocationArea,
            record.CheckinPlace,
            record.Latitude,
            record.LocationHistoryTrail,
            record.GeofenceEntryEvent,
            record.RegionCode);
    }
}
