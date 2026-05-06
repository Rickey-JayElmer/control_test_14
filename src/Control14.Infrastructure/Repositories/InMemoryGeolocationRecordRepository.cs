using System.Collections.Concurrent;
using Control14.Application.Interfaces;
using Control14.Domain.Entities;

namespace Control14.Infrastructure.Repositories;

public class InMemoryGeolocationRecordRepository : IGeolocationRecordRepository
{
    private readonly ConcurrentDictionary<Guid, GeolocationRecord> _records = new();

    public Task<GeolocationRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        _records.TryGetValue(id, out var record);
        return Task.FromResult(record);
    }

    public Task<IEnumerable<GeolocationRecord>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult<IEnumerable<GeolocationRecord>>(_records.Values.ToList());
    }

    public Task AddAsync(GeolocationRecord record, CancellationToken cancellationToken = default)
    {
        _records.TryAdd(record.Id, record);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(GeolocationRecord record, CancellationToken cancellationToken = default)
    {
        _records[record.Id] = record;
        return Task.CompletedTask;
    }

    public Task DeleteAsync(GeolocationRecord record, CancellationToken cancellationToken = default)
    {
        _records.TryRemove(record.Id, out _);
        return Task.CompletedTask;
    }
}
