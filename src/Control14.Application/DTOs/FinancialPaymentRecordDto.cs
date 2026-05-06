namespace Control14.Application.DTOs;

public record FinancialPaymentRecordDto(
    Guid Id,
    string BankAccountNumber,
    string SortCode,
    string Iban,
    string SwiftBic,
    string CardPan,
    string CardExpiry,
    string CardCvv,
    string CardholderName,
    string CardToken);
