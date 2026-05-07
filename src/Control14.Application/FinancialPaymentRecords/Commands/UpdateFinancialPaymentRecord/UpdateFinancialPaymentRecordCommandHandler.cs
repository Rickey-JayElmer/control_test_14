using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.FinancialPaymentRecords.Commands.UpdateFinancialPaymentRecord;

public class UpdateFinancialPaymentRecordCommandHandler : IRequestHandler<UpdateFinancialPaymentRecordCommand, FinancialPaymentRecordDto?>
{
    private readonly IFinancialPaymentRecordRepository _repository;

    public UpdateFinancialPaymentRecordCommandHandler(IFinancialPaymentRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<FinancialPaymentRecordDto?> Handle(UpdateFinancialPaymentRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return null;

        record.Update(
            request.BankAccountNumber,
            request.SortCode,
            request.Iban,
            request.SwiftBic,
            request.CardPan,
            request.CardExpiry,
            request.CardCvv,
            request.CardholderName,
            request.CardToken,
            request.TransactionId,
            request.TransactionAmount,
            request.TxnCurrency,
            request.TransactionDate,
            request.FxRate,
            request.TaxAmount,
            request.TipAmount,
            request.FeeAmount,
            request.AuthCode,
            request.AuthTimestamp,
            request.CaptureTimestamp,
            request.SubscriptionMandateId,
            request.PaymentMethodId,
            request.StripeCustomerId,
            request.FraudRiskScore,
            request.MerchantId,
            request.Mcc,
            request.BankruptcyFiling,
            request.TaxReturnDocument,
            request.CreditCardNumber,
            request.Pan,
            request.Cvv2,
            request.ExpMonth,
            request.AccountNumber,
            request.InternationalBankAccount,
            request.Amount,
            request.TxnId,
            request.NameOnCard,
            request.IsoCurrency,
            request.Mid,
            request.PaymentMethodToken,
            request.CardholderLegalName,
            request.UserIban,
            request.StripeExternalCustomerId,
            request.W2TaxForm,
            request.PaymentReceiptJson,
            request.AuthorizationResponseBlob,
            request.CreditCardStatement);

        await _repository.UpdateAsync(record, cancellationToken);

        return record.ToDto();
    }
}
