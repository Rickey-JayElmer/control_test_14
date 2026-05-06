using Control14.Application.Interfaces;
using MediatR;

namespace Control14.Application.AiInferenceRecords.Commands.DeleteAiInferenceRecord;

public class DeleteAiInferenceRecordCommandHandler : IRequestHandler<DeleteAiInferenceRecordCommand, bool>
{
    private readonly IAiInferenceRecordRepository _repository;

    public DeleteAiInferenceRecordCommandHandler(IAiInferenceRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<bool> Handle(DeleteAiInferenceRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return false;

        await _repository.DeleteAsync(record, cancellationToken);

        return true;
    }
}
