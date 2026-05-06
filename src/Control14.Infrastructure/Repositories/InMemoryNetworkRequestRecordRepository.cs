using System.Collections.Concurrent;
using Control14.Application.Interfaces;
using Control14.Domain.Entities;

namespace Control14.Infrastructure.Repositories;

public class InMemoryNetworkRequestRecordRepository : INetworkRequestRecordRepository
{
    private readonly ConcurrentDictionary<Guid, NetworkRequestRecord> _records = new();

    public Task<NetworkRequestRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        _records.TryGetValue(id, out var record);
        return Task.FromResult(record);
    }

    public Task<IEnumerable<NetworkRequestRecord>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult<IEnumerable<NetworkRequestRecord>>(_records.Values.ToList());
    }

    public Task AddAsync(NetworkRequestRecord record, CancellationToken cancellationToken = default)
    {
        _records.TryAdd(record.Id, record);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(NetworkRequestRecord record, CancellationToken cancellationToken = default)
    {
        _records[record.Id] = record;
        return Task.CompletedTask;
    }

    public Task DeleteAsync(NetworkRequestRecord record, CancellationToken cancellationToken = default)
    {
        _records.TryRemove(record.Id, out _);
        return Task.CompletedTask;
    }
}
