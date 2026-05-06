using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.NetworkRequestRecords.Queries.GetNetworkRequestRecordById;

public class GetNetworkRequestRecordByIdQueryHandler : IRequestHandler<GetNetworkRequestRecordByIdQuery, NetworkRequestRecordDto?>
{
    private readonly INetworkRequestRecordRepository _repository;

    public GetNetworkRequestRecordByIdQueryHandler(INetworkRequestRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<NetworkRequestRecordDto?> Handle(GetNetworkRequestRecordByIdQuery request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);
        return record?.ToDto();
    }
}
