using Control14.Application.Interfaces;
using MediatR;

namespace Control14.Application.LegalRecords.Commands.DeleteLegalRecord;

public class DeleteLegalRecordCommandHandler : IRequestHandler<DeleteLegalRecordCommand, bool>
{
    private readonly ILegalRecordRepository _repository;

    public DeleteLegalRecordCommandHandler(ILegalRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteLegalRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return false;

        await _repository.DeleteAsync(record, cancellationToken);

        return true;
    }
}
