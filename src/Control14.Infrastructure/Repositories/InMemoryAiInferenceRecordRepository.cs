using System.Collections.Concurrent;
using Control14.Application.Interfaces;
using Control14.Domain.Entities;

namespace Control14.Infrastructure.Repositories;

public class InMemoryAiInferenceRecordRepository : IAiInferenceRecordRepository
{
    private readonly ConcurrentDictionary<Guid, AiInferenceRecord> _records = new();

    public Task<AiInferenceRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        _records.TryGetValue(id, out var record);
        return Task.FromResult(record);
    }

    public Task<IEnumerable<AiInferenceRecord>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult<IEnumerable<AiInferenceRecord>>(_records.Values.ToList());
    }

    public Task AddAsync(AiInferenceRecord record, CancellationToken cancellationToken = default)
    {
        _records.TryAdd(record.Id, record);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(AiInferenceRecord record, CancellationToken cancellationToken = default)
    {
        _records[record.Id] = record;
        return Task.CompletedTask;
    }

    public Task DeleteAsync(AiInferenceRecord record, CancellationToken cancellationToken = default)
    {
        _records.TryRemove(record.Id, out _);
        return Task.CompletedTask;
    }
}
