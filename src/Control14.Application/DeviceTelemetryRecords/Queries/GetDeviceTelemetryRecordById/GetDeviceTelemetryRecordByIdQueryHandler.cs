using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.DeviceTelemetryRecords.Queries.GetDeviceTelemetryRecordById;

public class GetDeviceTelemetryRecordByIdQueryHandler : IRequestHandler<GetDeviceTelemetryRecordByIdQuery, DeviceTelemetryRecordDto?>
{
    private readonly IDeviceTelemetryRecordRepository _repository;

    public GetDeviceTelemetryRecordByIdQueryHandler(IDeviceTelemetryRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<DeviceTelemetryRecordDto?> Handle(GetDeviceTelemetryRecordByIdQuery request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);
        return record?.ToDto();
    }
}
