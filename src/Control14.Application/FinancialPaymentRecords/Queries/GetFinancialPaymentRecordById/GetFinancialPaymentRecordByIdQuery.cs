using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.FinancialPaymentRecords.Queries.GetFinancialPaymentRecordById;

public record GetFinancialPaymentRecordByIdQuery(Guid Id) : IRequest<FinancialPaymentRecordDto?>;
