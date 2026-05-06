using MediatR;

namespace Control14.Application.DeviceTelemetryRecords.Commands.DeleteDeviceTelemetryRecord;

public record DeleteDeviceTelemetryRecordCommand(Guid Id) : IRequest<bool>;
