using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.DeviceTelemetryRecords.Queries.GetDeviceTelemetryRecordById;

public record GetDeviceTelemetryRecordByIdQuery(Guid Id) : IRequest<DeviceTelemetryRecordDto?>;
