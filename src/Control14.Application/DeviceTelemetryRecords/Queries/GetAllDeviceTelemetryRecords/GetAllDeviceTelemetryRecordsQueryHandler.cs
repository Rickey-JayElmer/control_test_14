using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.DeviceTelemetryRecords.Queries.GetAllDeviceTelemetryRecords;

public class GetAllDeviceTelemetryRecordsQueryHandler : IRequestHandler<GetAllDeviceTelemetryRecordsQuery, IEnumerable<DeviceTelemetryRecordDto>>
{
    private readonly IDeviceTelemetryRecordRepository _repository;

    public GetAllDeviceTelemetryRecordsQueryHandler(IDeviceTelemetryRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<DeviceTelemetryRecordDto>> Handle(GetAllDeviceTelemetryRecordsQuery request, CancellationToken cancellationToken)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        return records.Select(r => r.ToDto());
    }
}
