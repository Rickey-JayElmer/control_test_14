using Control14.Application.Interfaces;
using MediatR;

namespace Control14.Application.OrganizationRecords.Commands.DeleteOrganizationRecord;

public class DeleteOrganizationRecordCommandHandler : IRequestHandler<DeleteOrganizationRecordCommand, bool>
{
    private readonly IOrganizationRecordRepository _repository;

    public DeleteOrganizationRecordCommandHandler(IOrganizationRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteOrganizationRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return false;

        await _repository.DeleteAsync(record, cancellationToken);

        return true;
    }
}
