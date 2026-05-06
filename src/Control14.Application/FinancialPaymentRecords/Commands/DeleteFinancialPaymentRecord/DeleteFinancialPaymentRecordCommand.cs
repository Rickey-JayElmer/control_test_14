using MediatR;

namespace Control14.Application.FinancialPaymentRecords.Commands.DeleteFinancialPaymentRecord;

public record DeleteFinancialPaymentRecordCommand(Guid Id) : IRequest<bool>;
