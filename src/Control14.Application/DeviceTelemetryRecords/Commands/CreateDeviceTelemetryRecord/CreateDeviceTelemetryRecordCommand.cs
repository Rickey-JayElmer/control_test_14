using System.Text.Json.Serialization;
using MediatR;

namespace Control14.Application.DeviceTelemetryRecords.Commands.CreateDeviceTelemetryRecord;

public record CreateDeviceTelemetryRecordCommand(
    [property: JsonPropertyName("device_profile")] string DeviceProfile,
    [property: JsonPropertyName("advertising_id")] string AdvertisingId,
    [property: JsonPropertyName("device_serial_number")] string DeviceSerialNumber,
    [property: JsonPropertyName("user_agent")] string UserAgent,
    [property: JsonPropertyName("device_fingerprint_hash")] string DeviceFingerprintHash,
    [property: JsonPropertyName("session_cookie_id")] string SessionCookieId,
    [property: JsonPropertyName("utm_campaign_id")] string UtmCampaignId,
    [property: JsonPropertyName("idfa")] string Idfa,
    [property: JsonPropertyName("cookie_value")] string CookieValue) : IRequest<Guid>;
