using Control14.Application.Interfaces;
using MediatR;

namespace Control14.Application.HrRecords.Commands.DeleteHrRecord;

public class DeleteHrRecordCommandHandler : IRequestHandler<DeleteHrRecordCommand, bool>
{
    private readonly IHrRecordRepository _repository;

    public DeleteHrRecordCommandHandler(IHrRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteHrRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return false;

        await _repository.DeleteAsync(record, cancellationToken);

        return true;
    }
}
