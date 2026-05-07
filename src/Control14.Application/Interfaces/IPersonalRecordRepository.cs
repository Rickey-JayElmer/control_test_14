using Control14.Domain.Entities;

namespace Control14.Application.Interfaces;

public interface IPersonalRecordRepository
{
    Task<PersonalRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<PersonalRecord>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(PersonalRecord record, CancellationToken cancellationToken = default);
    Task UpdateAsync(PersonalRecord record, CancellationToken cancellationToken = default);
    Task DeleteAsync(PersonalRecord record, CancellationToken cancellationToken = default);
}
