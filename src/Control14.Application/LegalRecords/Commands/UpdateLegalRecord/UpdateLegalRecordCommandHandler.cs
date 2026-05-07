using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.LegalRecords.Commands.UpdateLegalRecord;

public class UpdateLegalRecordCommandHandler : IRequestHandler<UpdateLegalRecordCommand, LegalRecordDto?>
{
    private readonly ILegalRecordRepository _repository;

    public UpdateLegalRecordCommandHandler(ILegalRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<LegalRecordDto?> Handle(UpdateLegalRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return null;

        record.Update(
            request.ConvictionRecord,
            request.IndictmentRecord,
            request.ArrestRecord,
            request.IncarcerationRecord,
            request.ParoleRecord,
            request.SexOffenderRegistryFlag,
            request.BackgroundCheckResult,
            request.CourtJudgment,
            request.CourtCaseFile,
            request.FineAmount,
            request.InvestigationNotes);

        await _repository.UpdateAsync(record, cancellationToken);

        return record.ToDto();
    }
}
