using Control14.Domain.Entities;

namespace Control14.Application.Interfaces;

public interface INetworkRequestRecordRepository
{
    Task<NetworkRequestRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<NetworkRequestRecord>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(NetworkRequestRecord record, CancellationToken cancellationToken = default);
    Task UpdateAsync(NetworkRequestRecord record, CancellationToken cancellationToken = default);
    Task DeleteAsync(NetworkRequestRecord record, CancellationToken cancellationToken = default);
}
