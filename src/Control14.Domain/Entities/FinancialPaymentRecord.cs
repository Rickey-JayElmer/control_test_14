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
        string cardToken)
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
            CardToken = cardToken
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
        string cardToken)
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
    }
}
