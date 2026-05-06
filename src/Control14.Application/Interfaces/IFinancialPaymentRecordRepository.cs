using Control14.Domain.Entities;

namespace Control14.Application.Interfaces;

public interface IFinancialPaymentRecordRepository
{
    Task<FinancialPaymentRecord?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<FinancialPaymentRecord>> GetAllAsync(CancellationToken cancellationToken = default);
    Task AddAsync(FinancialPaymentRecord record, CancellationToken cancellationToken = default);
    Task UpdateAsync(FinancialPaymentRecord record, CancellationToken cancellationToken = default);
    Task DeleteAsync(FinancialPaymentRecord record, CancellationToken cancellationToken = default);
}
