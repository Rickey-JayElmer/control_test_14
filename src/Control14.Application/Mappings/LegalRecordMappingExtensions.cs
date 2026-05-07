using Control14.Application.DTOs;
using Control14.Domain.Entities;

namespace Control14.Application.Mappings;

public static class LegalRecordMappingExtensions
{
    public static LegalRecordDto ToDto(this LegalRecord record)
    {
        return new LegalRecordDto(
            record.Id,
            record.ConvictionRecord,
            record.IndictmentRecord,
            record.ArrestRecord,
            record.IncarcerationRecord,
            record.ParoleRecord,
            record.SexOffenderRegistryFlag,
            record.BackgroundCheckResult,
            record.CourtJudgment,
            record.CourtCaseFile,
            record.FineAmount,
            record.InvestigationNotes);
    }
}
