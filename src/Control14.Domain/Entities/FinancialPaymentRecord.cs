namespace Control14.Domain.Entities;

public class FinancialPaymentRecord
{
    public Guid Id { get; private set; }
    public string BankAccountNumber { get; private set; } = string.Empty;
    public string SortCode { get; private set; } = string.Empty;
    public string Iban { get; private set; } = string.Empty;
    public string SwiftBic { get; private set; } = string.Empty;
    public string CardPan { get; private set; } = string.Empty;
    public string CardExpiry { get; private set; } = string.Empty;
    public string CardCvv { get; private set; } = string.Empty;
    public string CardholderName { get; private set; } = string.Empty;
    public string CardToken { get; private set; } = string.Empty;
    public string TransactionId { get; private set; } = string.Empty;
    public double TransactionAmount { get; private set; }
    public string TxnCurrency { get; private set; } = string.Empty;
    public string TransactionDate { get; private set; } = string.Empty;
    public double FxRate { get; private set; }
    public double TaxAmount { get; private set; }
    public double TipAmount { get; private set; }
    public double FeeAmount { get; private set; }
    public string AuthCode { get; private set; } = string.Empty;
    public string AuthTimestamp { get; private set; } = string.Empty;
    public string CaptureTimestamp { get; private set; } = string.Empty;
    public string SubscriptionMandateId { get; private set; } = string.Empty;
    public string PaymentMethodId { get; private set; } = string.Empty;
    public string StripeCustomerId { get; private set; } = string.Empty;
    public double FraudRiskScore { get; private set; }
    public string MerchantId { get; private set; } = string.Empty;
    public string Mcc { get; private set; } = string.Empty;
    public string BankruptcyFiling { get; private set; } = string.Empty;
    public string TaxReturnDocument { get; private set; } = string.Empty;
    public string CreditCardNumber { get; private set; } = string.Empty;
    public string Pan { get; private set; } = string.Empty;
    public string Cvv2 { get; private set; } = string.Empty;
    public string ExpMonth { get; private set; } = string.Empty;
    public string AccountNumber { get; private set; } = string.Empty;
    public string InternationalBankAccount { get; private set; } = string.Empty;
    public double Amount { get; private set; }
    public string TxnId { get; private set; } = string.Empty;
    public string NameOnCard { get; private set; } = string.Empty;
    public string IsoCurrency { get; private set; } = string.Empty;
    public string Mid { get; private set; } = string.Empty;
    public string PaymentMethodToken { get; private set; } = string.Empty;
    public string CardholderLegalName { get; private set; } = string.Empty;
    public string UserIban { get; private set; } = string.Empty;
    public string StripeExternalCustomerId { get; private set; } = string.Empty;
    public string W2TaxForm { get; private set; } = string.Empty;
    public string PaymentReceiptJson { get; private set; } = string.Empty;
    public string AuthorizationResponseBlob { get; private set; } = string.Empty;
    public string CreditCardStatement { get; private set; } = string.Empty;

    private FinancialPaymentRecord() { }

    public static FinancialPaymentRecord Create(
        string bankAccountNumber,
        string sortCode,
        string iban,
        string swiftBic,
        string cardPan,
        string cardExpiry,
        string cardCvv,
        string cardholderName,
        string cardToken,
        string transactionId,
        double transactionAmount,
        string txnCurrency,
        string transactionDate,
        double fxRate,
        double taxAmount,
        double tipAmount,
        double feeAmount,
        string authCode,
        string authTimestamp,
        string captureTimestamp,
        string subscriptionMandateId,
        string paymentMethodId,
        string stripeCustomerId,
        double fraudRiskScore,
        string merchantId,
        string mcc,
        string bankruptcyFiling,
        string taxReturnDocument,
        string creditCardNumber,
        string pan,
        string cvv2,
        string expMonth,
        string accountNumber,
        string internationalBankAccount,
        double amount,
        string txnId,
        string nameOnCard,
        string isoCurrency,
        string mid,
        string paymentMethodToken,
        string cardholderLegalName,
        string userIban,
        string stripeExternalCustomerId,
        string w2TaxForm,
        string paymentReceiptJson,
        string authorizationResponseBlob,
        string creditCardStatement)
    {
        return new FinancialPaymentRecord
        {
            Id = Guid.NewGuid(),
            BankAccountNumber = bankAccountNumber,
            SortCode = sortCode,
            Iban = iban,
            SwiftBic = swiftBic,
            CardPan = cardPan,
            CardExpiry = cardExpiry,
            CardCvv = cardCvv,
            CardholderName = cardholderName,
            CardToken = cardToken,
            TransactionId = transactionId,
            TransactionAmount = transactionAmount,
            TxnCurrency = txnCurrency,
            TransactionDate = transactionDate,
            FxRate = fxRate,
            TaxAmount = taxAmount,
            TipAmount = tipAmount,
            FeeAmount = feeAmount,
            AuthCode = authCode,
            AuthTimestamp = authTimestamp,
            CaptureTimestamp = captureTimestamp,
            SubscriptionMandateId = subscriptionMandateId,
            PaymentMethodId = paymentMethodId,
            StripeCustomerId = stripeCustomerId,
            FraudRiskScore = fraudRiskScore,
            MerchantId = merchantId,
            Mcc = mcc,
            BankruptcyFiling = bankruptcyFiling,
            TaxReturnDocument = taxReturnDocument,
            CreditCardNumber = creditCardNumber,
            Pan = pan,
            Cvv2 = cvv2,
            ExpMonth = expMonth,
            AccountNumber = accountNumber,
            InternationalBankAccount = internationalBankAccount,
            Amount = amount,
            TxnId = txnId,
            NameOnCard = nameOnCard,
            IsoCurrency = isoCurrency,
            Mid = mid,
            PaymentMethodToken = paymentMethodToken,
            CardholderLegalName = cardholderLegalName,
            UserIban = userIban,
            StripeExternalCustomerId = stripeExternalCustomerId,
            W2TaxForm = w2TaxForm,
            PaymentReceiptJson = paymentReceiptJson,
            AuthorizationResponseBlob = authorizationResponseBlob,
            CreditCardStatement = creditCardStatement
        };
    }

    public void Update(
        string bankAccountNumber,
        string sortCode,
        string iban,
        string swiftBic,
        string cardPan,
        string cardExpiry,
        string cardCvv,
        string cardholderName,
        string cardToken,
        string transactionId,
        double transactionAmount,
        string txnCurrency,
        string transactionDate,
        double fxRate,
        double taxAmount,
        double tipAmount,
        double feeAmount,
        string authCode,
        string authTimestamp,
        string captureTimestamp,
        string subscriptionMandateId,
        string paymentMethodId,
        string stripeCustomerId,
        double fraudRiskScore,
        string merchantId,
        string mcc,
        string bankruptcyFiling,
        string taxReturnDocument,
        string creditCardNumber,
        string pan,
        string cvv2,
        string expMonth,
        string accountNumber,
        string internationalBankAccount,
        double amount,
        string txnId,
        string nameOnCard,
        string isoCurrency,
        string mid,
        string paymentMethodToken,
        string cardholderLegalName,
        string userIban,
        string stripeExternalCustomerId,
        string w2TaxForm,
        string paymentReceiptJson,
        string authorizationResponseBlob,
        string creditCardStatement)
    {
        BankAccountNumber = bankAccountNumber;
        SortCode = sortCode;
        Iban = iban;
        SwiftBic = swiftBic;
        CardPan = cardPan;
        CardExpiry = cardExpiry;
        CardCvv = cardCvv;
        CardholderName = cardholderName;
        CardToken = cardToken;
        TransactionId = transactionId;
        TransactionAmount = transactionAmount;
        TxnCurrency = txnCurrency;
        TransactionDate = transactionDate;
        FxRate = fxRate;
        TaxAmount = taxAmount;
        TipAmount = tipAmount;
        FeeAmount = feeAmount;
        AuthCode = authCode;
        AuthTimestamp = authTimestamp;
        CaptureTimestamp = captureTimestamp;
        SubscriptionMandateId = subscriptionMandateId;
        PaymentMethodId = paymentMethodId;
        StripeCustomerId = stripeCustomerId;
        FraudRiskScore = fraudRiskScore;
        MerchantId = merchantId;
        Mcc = mcc;
        BankruptcyFiling = bankruptcyFiling;
        TaxReturnDocument = taxReturnDocument;
        CreditCardNumber = creditCardNumber;
        Pan = pan;
        Cvv2 = cvv2;
        ExpMonth = expMonth;
        AccountNumber = accountNumber;
        InternationalBankAccount = internationalBankAccount;
        Amount = amount;
        TxnId = txnId;
        NameOnCard = nameOnCard;
        IsoCurrency = isoCurrency;
        Mid = mid;
        PaymentMethodToken = paymentMethodToken;
        CardholderLegalName = cardholderLegalName;
        UserIban = userIban;
        StripeExternalCustomerId = stripeExternalCustomerId;
        W2TaxForm = w2TaxForm;
        PaymentReceiptJson = paymentReceiptJson;
        AuthorizationResponseBlob = authorizationResponseBlob;
        CreditCardStatement = creditCardStatement;
    }
}
