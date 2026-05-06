using Control14.Application.Interfaces;
using MediatR;

namespace Control14.Application.NetworkRequestRecords.Commands.DeleteNetworkRequestRecord;

public class DeleteNetworkRequestRecordCommandHandler : IRequestHandler<DeleteNetworkRequestRecordCommand, bool>
{
    private readonly INetworkRequestRecordRepository _repository;

    public DeleteNetworkRequestRecordCommandHandler(INetworkRequestRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteNetworkRequestRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return false;

        await _repository.DeleteAsync(record, cancellationToken);

        return true;
    }
}
