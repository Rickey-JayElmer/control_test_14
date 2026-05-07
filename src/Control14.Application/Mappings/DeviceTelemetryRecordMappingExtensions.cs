using Control14.Application.DTOs;
using Control14.Domain.Entities;

namespace Control14.Application.Mappings;

public static class DeviceTelemetryRecordMappingExtensions
{
    public static DeviceTelemetryRecordDto ToDto(this DeviceTelemetryRecord record)
    {
        return new DeviceTelemetryRecordDto(
            record.Id,
            record.DeviceProfile,
            record.AdvertisingId,
            record.DeviceSerialNumber,
            record.UserAgent,
            record.DeviceFingerprintHash,
            record.SessionCookieId,
            record.UtmCampaignId,
            record.Idfa,
            record.CookieValue);
    }
}
