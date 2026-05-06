using Control14.Application.Interfaces;
using MediatR;

namespace Control14.Application.DeviceTelemetryRecords.Commands.DeleteDeviceTelemetryRecord;

public class DeleteDeviceTelemetryRecordCommandHandler : IRequestHandler<DeleteDeviceTelemetryRecordCommand, bool>
{
    private readonly IDeviceTelemetryRecordRepository _repository;

    public DeleteDeviceTelemetryRecordCommandHandler(IDeviceTelemetryRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteDeviceTelemetryRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return false;

        await _repository.DeleteAsync(record, cancellationToken);

        return true;
    }
}
