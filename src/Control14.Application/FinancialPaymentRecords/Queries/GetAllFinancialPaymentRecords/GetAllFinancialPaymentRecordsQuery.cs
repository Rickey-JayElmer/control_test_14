using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.FinancialPaymentRecords.Queries.GetAllFinancialPaymentRecords;

public record GetAllFinancialPaymentRecordsQuery() : IRequest<IEnumerable<FinancialPaymentRecordDto>>;
