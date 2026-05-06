using Control14.Domain.Entities;

namespace Control14.Application.Interfaces;

public interface IGeolocationRecordRepository
{
    Task<GeolocationRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<GeolocationRecord>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(GeolocationRecord record, CancellationToken cancellationToken = default);
    Task UpdateAsync(GeolocationRecord record, CancellationToken cancellationToken = default);
    Task DeleteAsync(GeolocationRecord record, CancellationToken cancellationToken = default);
}
