using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.DeviceTelemetryRecords.Commands.UpdateDeviceTelemetryRecord;

public class UpdateDeviceTelemetryRecordCommandHandler : IRequestHandler<UpdateDeviceTelemetryRecordCommand, DeviceTelemetryRecordDto?>
{
    private readonly IDeviceTelemetryRecordRepository _repository;

    public UpdateDeviceTelemetryRecordCommandHandler(IDeviceTelemetryRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<DeviceTelemetryRecordDto?> Handle(UpdateDeviceTelemetryRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return null;

        record.Update(
            request.DeviceProfile,
            request.AdvertisingId,
            request.DeviceSerialNumber,
            request.UserAgent,
            request.DeviceFingerprintHash,
            request.SessionCookieId,
            request.UtmCampaignId);

        await _repository.UpdateAsync(record, cancellationToken);

        return record.ToDto();
    }
}
