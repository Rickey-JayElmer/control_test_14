using Control14.Application.Interfaces;
using MediatR;

namespace Control14.Application.PersonalRecords.Commands.DeletePersonalRecord;

public class DeletePersonalRecordCommandHandler : IRequestHandler<DeletePersonalRecordCommand, bool>
{
    private readonly IPersonalRecordRepository _repository;

    public DeletePersonalRecordCommandHandler(IPersonalRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeletePersonalRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return false;

        await _repository.DeleteAsync(record, cancellationToken);

        return true;
    }
}
