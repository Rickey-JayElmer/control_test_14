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
            record.CardToken,
            record.TransactionId,
            record.TransactionAmount,
            record.TxnCurrency,
            record.TransactionDate,
            record.FxRate,
            record.TaxAmount,
            record.TipAmount,
            record.FeeAmount,
            record.AuthCode,
            record.AuthTimestamp,
            record.CaptureTimestamp,
            record.SubscriptionMandateId,
            record.PaymentMethodId,
            record.StripeCustomerId,
            record.FraudRiskScore,
            record.MerchantId,
            record.Mcc,
            record.BankruptcyFiling,
            record.TaxReturnDocument,
            record.CreditCardNumber,
            record.Pan,
            record.Cvv2,
            record.ExpMonth,
            record.AccountNumber,
            record.InternationalBankAccount,
            record.Amount,
            record.TxnId,
            record.NameOnCard,
            record.IsoCurrency,
            record.Mid,
            record.PaymentMethodToken,
            record.CardholderLegalName,
            record.UserIban,
            record.StripeExternalCustomerId,
            record.W2TaxForm,
            record.PaymentReceiptJson,
            record.AuthorizationResponseBlob,
            record.CreditCardStatement);
    }
}
