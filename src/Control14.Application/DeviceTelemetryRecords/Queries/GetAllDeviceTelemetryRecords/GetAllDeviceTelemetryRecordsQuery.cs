using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.DeviceTelemetryRecords.Queries.GetAllDeviceTelemetryRecords;

public record GetAllDeviceTelemetryRecordsQuery() : IRequest<IEnumerable<DeviceTelemetryRecordDto>>;
