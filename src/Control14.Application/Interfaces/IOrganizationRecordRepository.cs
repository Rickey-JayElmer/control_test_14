using Control14.Domain.Entities;

namespace Control14.Application.Interfaces;

public interface IOrganizationRecordRepository
{
    Task<OrganizationRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<OrganizationRecord>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(OrganizationRecord record, CancellationToken cancellationToken = default);
    Task UpdateAsync(OrganizationRecord record, CancellationToken cancellationToken = default);
    Task DeleteAsync(OrganizationRecord record, CancellationToken cancellationToken = default);
}
