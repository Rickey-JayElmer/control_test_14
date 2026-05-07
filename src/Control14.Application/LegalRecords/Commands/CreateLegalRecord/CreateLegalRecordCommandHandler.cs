using Control14.Application.Interfaces;
using Control14.Domain.Entities;
using MediatR;

namespace Control14.Application.LegalRecords.Commands.CreateLegalRecord;

public class CreateLegalRecordCommandHandler : IRequestHandler<CreateLegalRecordCommand, Guid>
{
    private readonly ILegalRecordRepository _repository;

    public CreateLegalRecordCommandHandler(ILegalRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateLegalRecordCommand request, CancellationToken cancellationToken)
    {
        var record = LegalRecord.Create(
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

        await _repository.AddAsync(record, cancellationToken);

        return record.Id;
    }
}
