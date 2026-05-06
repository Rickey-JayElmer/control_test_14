using Control14.Application.Interfaces;
using MediatR;

namespace Control14.Application.GeolocationRecords.Commands.DeleteGeolocationRecord;

public class DeleteGeolocationRecordCommandHandler : IRequestHandler<DeleteGeolocationRecordCommand, bool>
{
    private readonly IGeolocationRecordRepository _repository;

    public DeleteGeolocationRecordCommandHandler(IGeolocationRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteGeolocationRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return false;

        await _repository.DeleteAsync(record, cancellationToken);

        return true;
    }
}
