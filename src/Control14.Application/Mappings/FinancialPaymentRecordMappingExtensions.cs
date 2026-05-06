using Control14.Application.DTOs;
using Control14.Domain.Entities;

namespace Control14.Application.Mappings;

public static class FinancialPaymentRecordMappingExtensions
{
    public static FinancialPaymentRecordDto ToDto(this FinancialPaymentRecord record)
    {
        return new FinancialPaymentRecordDto(
            record.Id,
            record.BankAccountNumber,
            record.SortCode,
            record.Iban,
            record.SwiftBic,
            record.CardPan,
            record.CardExpiry,
            record.CardCvv,
            record.CardholderName,
            record.CardToken);
    }
}
