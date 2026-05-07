using System.Text.Json.Serialization;
using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.LegalRecords.Commands.UpdateLegalRecord;

public record UpdateLegalRecordCommand(
    Guid Id,
    [property: JsonPropertyName("conviction_record")] string ConvictionRecord,
    [property: JsonPropertyName("indictment_record")] string IndictmentRecord,
    [property: JsonPropertyName("arrest_record")] string ArrestRecord,
    [property: JsonPropertyName("incarceration_record")] string IncarcerationRecord,
    [property: JsonPropertyName("parole_record")] string ParoleRecord,
    [property: JsonPropertyName("sex_offender_registry_flag")] string SexOffenderRegistryFlag,
    [property: JsonPropertyName("background_check_result")] string BackgroundCheckResult,
    [property: JsonPropertyName("court_judgment")] string CourtJudgment,
    [property: JsonPropertyName("court_case_file")] string CourtCaseFile,
    [property: JsonPropertyName("fine_amount")] double FineAmount,
    [property: JsonPropertyName("investigation_notes")] string InvestigationNotes) : IRequest<LegalRecordDto?>;
