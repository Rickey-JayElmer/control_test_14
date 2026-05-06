namespace Control14.Domain.Entities;

public class GeolocationRecord
{
    public Guid Id { get; private set; }
    public string LocationData { get; private set; } = string.Empty;
    public string GpsReading { get; private set; } = string.Empty;
    public string HomeLocationArea { get; private set; } = string.Empty;
    public string CheckinPlace { get; private set; } = string.Empty;
    public double Latitude { get; private set; }
    public string LocationHistoryTrail { get; private set; } = string.Empty;
    public string GeofenceEntryEvent { get; private set; } = string.Empty;
    public string RegionCode { get; private set; } = string.Empty;

    private GeolocationRecord() { }

    public static GeolocationRecord Create(
        string locationData,
        string gpsReading,
        string homeLocationArea,
        string checkinPlace,
        double latitude,
        string locationHistoryTrail,
        string geofenceEntryEvent,
        string regionCode)
    {
        return new GeolocationRecord
        {
            Id = Guid.NewGuid(),
            LocationData = locationData,
            GpsReading = gpsReading,
            HomeLocationArea = homeLocationArea,
            CheckinPlace = checkinPlace,
            Latitude = latitude,
            LocationHistoryTrail = locationHistoryTrail,
            GeofenceEntryEvent = geofenceEntryEvent,
            RegionCode = regionCode
        };
    }

    public void Update(
        string locationData,
        string gpsReading,
        string homeLocationArea,
        string checkinPlace,
        double latitude,
        string locationHistoryTrail,
        string geofenceEntryEvent,
        string regionCode)
    {
        LocationData = locationData;
        GpsReading = gpsReading;
        HomeLocationArea = homeLocationArea;
        CheckinPlace = checkinPlace;
        Latitude = latitude;
        LocationHistoryTrail = locationHistoryTrail;
        GeofenceEntryEvent = geofenceEntryEvent;
        RegionCode = regionCode;
    }
}
