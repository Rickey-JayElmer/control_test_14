namespace Control14.Domain.Entities;

public class DeviceTelemetryRecord
{
    public Guid Id { get; private set; }
    public string DeviceProfile { get; private set; } = string.Empty;
    public string AdvertisingId { get; private set; } = string.Empty;
    public string DeviceSerialNumber { get; private set; } = string.Empty;
    public string UserAgent { get; private set; } = string.Empty;
    public string DeviceFingerprintHash { get; private set; } = string.Empty;
    public string SessionCookieId { get; private set; } = string.Empty;
    public string UtmCampaignId { get; private set; } = string.Empty;
    public string Idfa { get; private set; } = string.Empty;
    public string CookieValue { get; private set; } = string.Empty;

    private DeviceTelemetryRecord() { }

    public static DeviceTelemetryRecord Create(
        string deviceProfile,
        string advertisingId,
        string deviceSerialNumber,
        string userAgent,
        string deviceFingerprintHash,
        string sessionCookieId,
        string utmCampaignId,
        string idfa,
        string cookieValue)
    {
        return new DeviceTelemetryRecord
        {
            Id = Guid.NewGuid(),
            DeviceProfile = deviceProfile,
            AdvertisingId = advertisingId,
            DeviceSerialNumber = deviceSerialNumber,
            UserAgent = userAgent,
            DeviceFingerprintHash = deviceFingerprintHash,
            SessionCookieId = sessionCookieId,
            UtmCampaignId = utmCampaignId,
            Idfa = idfa,
            CookieValue = cookieValue
        };
    }

    public void Update(
        string deviceProfile,
        string advertisingId,
        string deviceSerialNumber,
        string userAgent,
        string deviceFingerprintHash,
        string sessionCookieId,
        string utmCampaignId,
        string idfa,
        string cookieValue)
    {
        DeviceProfile = deviceProfile;
        AdvertisingId = advertisingId;
        DeviceSerialNumber = deviceSerialNumber;
        UserAgent = userAgent;
        DeviceFingerprintHash = deviceFingerprintHash;
        SessionCookieId = sessionCookieId;
        UtmCampaignId = utmCampaignId;
        Idfa = idfa;
        CookieValue = cookieValue;
    }
}
