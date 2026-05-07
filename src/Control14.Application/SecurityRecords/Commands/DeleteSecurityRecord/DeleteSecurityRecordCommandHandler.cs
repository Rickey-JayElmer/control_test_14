using Control14.Application.Interfaces;
using MediatR;

namespace Control14.Application.SecurityRecords.Commands.DeleteSecurityRecord;

public class DeleteSecurityRecordCommandHandler : IRequestHandler<DeleteSecurityRecordCommand, bool>
{
    private readonly ISecurityRecordRepository _repository;

    public DeleteSecurityRecordCommandHandler(ISecurityRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteSecurityRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return false;

        await _repository.DeleteAsync(record, cancellationToken);

        return true;
    }
}
