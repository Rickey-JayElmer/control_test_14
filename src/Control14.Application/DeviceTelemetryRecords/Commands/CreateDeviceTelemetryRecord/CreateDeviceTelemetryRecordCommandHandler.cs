using Control14.Application.Interfaces;
using Control14.Domain.Entities;
using MediatR;

namespace Control14.Application.DeviceTelemetryRecords.Commands.CreateDeviceTelemetryRecord;

public class CreateDeviceTelemetryRecordCommandHandler : IRequestHandler<CreateDeviceTelemetryRecordCommand, Guid>
{
    private readonly IDeviceTelemetryRecordRepository _repository;

    public CreateDeviceTelemetryRecordCommandHandler(IDeviceTelemetryRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateDeviceTelemetryRecordCommand request, CancellationToken cancellationToken)
    {
        var record = DeviceTelemetryRecord.Create(
            request.DeviceProfile,
            request.AdvertisingId,
            request.DeviceSerialNumber,
            request.UserAgent,
            request.DeviceFingerprintHash,
            request.SessionCookieId,
            request.UtmCampaignId);

        await _repository.AddAsync(record, cancellationToken);

        return record.Id;
    }
}
