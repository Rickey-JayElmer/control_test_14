using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.NetworkRequestRecords.Commands.UpdateNetworkRequestRecord;

public class UpdateNetworkRequestRecordCommandHandler : IRequestHandler<UpdateNetworkRequestRecordCommand, NetworkRequestRecordDto?>
{
    private readonly INetworkRequestRecordRepository _repository;

    public UpdateNetworkRequestRecordCommandHandler(INetworkRequestRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<NetworkRequestRecordDto?> Handle(UpdateNetworkRequestRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return null;

        record.Update(
            request.NetworkRequestInfo,
            request.ClientIp,
            request.ServerIp,
            request.MacAddress,
            request.FqdnHost,
            request.TcpPort,
            request.NicId,
            request.OriginAsn,
            request.RequestHeaders,
            request.ResponseHeaders);

        await _repository.UpdateAsync(record, cancellationToken);

        return record.ToDto();
    }
}
