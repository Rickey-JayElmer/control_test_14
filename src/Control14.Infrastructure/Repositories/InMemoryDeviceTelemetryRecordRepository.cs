using System.Collections.Concurrent;
using Control14.Application.Interfaces;
using Control14.Domain.Entities;

namespace Control14.Infrastructure.Repositories;

public class InMemoryDeviceTelemetryRecordRepository : IDeviceTelemetryRecordRepository
{
    private readonly ConcurrentDictionary<Guid, DeviceTelemetryRecord> _records = new();

    public Task<DeviceTelemetryRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        _records.TryGetValue(id, out var record);
        return Task.FromResult(record);
    }

    public Task<IEnumerable<DeviceTelemetryRecord>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult<IEnumerable<DeviceTelemetryRecord>>(_records.Values.ToList());
    }

    public Task AddAsync(DeviceTelemetryRecord record, CancellationToken cancellationToken = default)
    {
        _records.TryAdd(record.Id, record);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(DeviceTelemetryRecord record, CancellationToken cancellationToken = default)
    {
        _records[record.Id] = record;
        return Task.CompletedTask;
    }

    public Task DeleteAsync(DeviceTelemetryRecord record, CancellationToken cancellationToken = default)
    {
        _records.TryRemove(record.Id, out _);
        return Task.CompletedTask;
    }
}
