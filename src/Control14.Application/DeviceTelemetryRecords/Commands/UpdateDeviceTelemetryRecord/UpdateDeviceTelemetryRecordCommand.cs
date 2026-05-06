using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.DeviceTelemetryRecords.Commands.UpdateDeviceTelemetryRecord;

public record UpdateDeviceTelemetryRecordCommand(
    Guid Id,
    string DeviceProfile,
    string AdvertisingId,
    string DeviceSerialNumber,
    string UserAgent,
    string DeviceFingerprintHash,
    string SessionCookieId,
    string UtmCampaignId) : IRequest<DeviceTelemetryRecordDto?>;
