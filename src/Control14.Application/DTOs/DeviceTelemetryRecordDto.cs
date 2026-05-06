namespace Control14.Application.DTOs;

public record DeviceTelemetryRecordDto(
    Guid Id,
    string DeviceProfile,
    string AdvertisingId,
    string DeviceSerialNumber,
    string UserAgent,
    string DeviceFingerprintHash,
    string SessionCookieId,
    string UtmCampaignId);
