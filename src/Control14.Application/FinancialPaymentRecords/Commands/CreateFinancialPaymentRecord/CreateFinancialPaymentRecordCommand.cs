using MediatR;

namespace Control14.Application.FinancialPaymentRecords.Commands.CreateFinancialPaymentRecord;

public record CreateFinancialPaymentRecordCommand(
    string BankAccountNumber,
    string SortCode,
    string Iban,
    string SwiftBic,
    string CardPan,
    string CardExpiry,
    string CardCvv,
    string CardholderName,
    string CardToken) : IRequest<Guid>;
