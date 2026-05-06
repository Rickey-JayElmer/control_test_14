using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.FinancialPaymentRecords.Commands.UpdateFinancialPaymentRecord;

public record UpdateFinancialPaymentRecordCommand(
    Guid Id,
    string BankAccountNumber,
    string SortCode,
    string Iban,
    string SwiftBic,
    string CardPan,
    string CardExpiry,
    string CardCvv,
    string CardholderName,
    string CardToken) : IRequest<FinancialPaymentRecordDto?>;
