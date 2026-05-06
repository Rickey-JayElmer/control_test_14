using MediatR;

namespace Control14.Application.DeviceTelemetryRecords.Commands.CreateDeviceTelemetryRecord;

public record CreateDeviceTelemetryRecordCommand(
    string DeviceProfile,
    string AdvertisingId,
    string DeviceSerialNumber,
    string UserAgent,
    string DeviceFingerprintHash,
    string SessionCookieId,
    string UtmCampaignId) : IRequest<Guid>;
