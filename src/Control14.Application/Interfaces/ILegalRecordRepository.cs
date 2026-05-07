using Control14.Domain.Entities;

namespace Control14.Application.Interfaces;

public interface ILegalRecordRepository
{
    Task<LegalRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<LegalRecord>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(LegalRecord record, CancellationToken cancellationToken = default);
    Task UpdateAsync(LegalRecord record, CancellationToken cancellationToken = default);
    Task DeleteAsync(LegalRecord record, CancellationToken cancellationToken = default);
}
