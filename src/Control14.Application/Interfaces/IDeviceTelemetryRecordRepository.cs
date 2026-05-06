using Control14.Domain.Entities;

namespace Control14.Application.Interfaces;

public interface IDeviceTelemetryRecordRepository
{
    Task<DeviceTelemetryRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<DeviceTelemetryRecord>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(DeviceTelemetryRecord record, CancellationToken cancellationToken = default);
    Task UpdateAsync(DeviceTelemetryRecord record, CancellationToken cancellationToken = default);
    Task DeleteAsync(DeviceTelemetryRecord record, CancellationToken cancellationToken = default);
}
