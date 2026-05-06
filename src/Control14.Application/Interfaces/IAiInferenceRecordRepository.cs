using Control14.Domain.Entities;

namespace Control14.Application.Interfaces;

public interface IAiInferenceRecordRepository
{
    Task<AiInferenceRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<AiInferenceRecord>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(AiInferenceRecord record, CancellationToken cancellationToken = default);
    Task UpdateAsync(AiInferenceRecord record, CancellationToken cancellationToken = default);
    Task DeleteAsync(AiInferenceRecord record, CancellationToken cancellationToken = default);
}
