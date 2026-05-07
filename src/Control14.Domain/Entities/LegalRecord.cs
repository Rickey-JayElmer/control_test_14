namespace Control14.Domain.Entities;

public class LegalRecord
{
    public Guid Id { get; private set; }
    public string ConvictionRecord { get; private set; } = string.Empty;
    public string IndictmentRecord { get; private set; } = string.Empty;
    public string ArrestRecord { get; private set; } = string.Empty;
    public string IncarcerationRecord { get; private set; } = string.Empty;
    public string ParoleRecord { get; private set; } = string.Empty;
    public string SexOffenderRegistryFlag { get; private set; } = string.Empty;
    public string BackgroundCheckResult { get; private set; } = string.Empty;
    public string CourtJudgment { get; private set; } = string.Empty;
    public string CourtCaseFile { get; private set; } = string.Empty;
    public double FineAmount { get; private set; }
    public string InvestigationNotes { get; private set; } = string.Empty;

    private LegalRecord() { }

    public static LegalRecord Create(
        string convictionRecord,
        string indictmentRecord,
        string arrestRecord,
        string incarcerationRecord,
        string paroleRecord,
        string sexOffenderRegistryFlag,
        string backgroundCheckResult,
        string courtJudgment,
        string courtCaseFile,
        double fineAmount,
        string investigationNotes)
    {
        return new LegalRecord
        {
            Id = Guid.NewGuid(),
            ConvictionRecord = convictionRecord,
            IndictmentRecord = indictmentRecord,
            ArrestRecord = arrestRecord,
            IncarcerationRecord = incarcerationRecord,
            ParoleRecord = paroleRecord,
            SexOffenderRegistryFlag = sexOffenderRegistryFlag,
            BackgroundCheckResult = backgroundCheckResult,
            CourtJudgment = courtJudgment,
            CourtCaseFile = courtCaseFile,
            FineAmount = fineAmount,
            InvestigationNotes = investigationNotes
        };
    }

    public void Update(
        string convictionRecord,
        string indictmentRecord,
        string arrestRecord,
        string incarcerationRecord,
        string paroleRecord,
        string sexOffenderRegistryFlag,
        string backgroundCheckResult,
        string courtJudgment,
        string courtCaseFile,
        double fineAmount,
        string investigationNotes)
    {
        ConvictionRecord = convictionRecord;
        IndictmentRecord = indictmentRecord;
        ArrestRecord = arrestRecord;
        IncarcerationRecord = incarcerationRecord;
        ParoleRecord = paroleRecord;
        SexOffenderRegistryFlag = sexOffenderRegistryFlag;
        BackgroundCheckResult = backgroundCheckResult;
        CourtJudgment = courtJudgment;
        CourtCaseFile = courtCaseFile;
        FineAmount = fineAmount;
        InvestigationNotes = investigationNotes;
    }
}
