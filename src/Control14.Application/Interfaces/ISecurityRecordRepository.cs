using Control14.Domain.Entities;

namespace Control14.Application.Interfaces;

public interface ISecurityRecordRepository
{
    Task<SecurityRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<SecurityRecord>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(SecurityRecord record, CancellationToken cancellationToken = default);
    Task UpdateAsync(SecurityRecord record, CancellationToken cancellationToken = default);
    Task DeleteAsync(SecurityRecord record, CancellationToken cancellationToken = default);
}
