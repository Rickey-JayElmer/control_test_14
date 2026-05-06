using System.Collections.Concurrent;
using Control14.Application.Interfaces;
using Control14.Domain.Entities;

namespace Control14.Infrastructure.Repositories;

public class InMemoryFinancialPaymentRecordRepository : IFinancialPaymentRecordRepository
{
    private readonly ConcurrentDictionary<Guid, FinancialPaymentRecord> _records = new();

    public Task<FinancialPaymentRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        _records.TryGetValue(id, out var record);
        return Task.FromResult(record);
    }

    public Task<IEnumerable<FinancialPaymentRecord>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return Task.FromResult<IEnumerable<FinancialPaymentRecord>>(_records.Values.ToList());
    }

    public Task AddAsync(FinancialPaymentRecord record, CancellationToken cancellationToken = default)
    {
        _records.TryAdd(record.Id, record);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(FinancialPaymentRecord record, CancellationToken cancellationToken = default)
    {
        _records[record.Id] = record;
        return Task.CompletedTask;
    }

    public Task DeleteAsync(FinancialPaymentRecord record, CancellationToken cancellationToken = default)
    {
        _records.TryRemove(record.Id, out _);
        return Task.CompletedTask;
    }
}
