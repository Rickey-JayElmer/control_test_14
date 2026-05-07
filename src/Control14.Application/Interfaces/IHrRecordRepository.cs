using Control14.Domain.Entities;

namespace Control14.Application.Interfaces;

public interface IHrRecordRepository
{
    Task<HrRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<HrRecord>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(HrRecord record, CancellationToken cancellationToken = default);
    Task UpdateAsync(HrRecord record, CancellationToken cancellationToken = default);
    Task DeleteAsync(HrRecord record, CancellationToken cancellationToken = default);
}
