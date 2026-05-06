using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.NetworkRequestRecords.Queries.GetAllNetworkRequestRecords;

public class GetAllNetworkRequestRecordsQueryHandler : IRequestHandler<GetAllNetworkRequestRecordsQuery, IEnumerable<NetworkRequestRecordDto>>
{
    private readonly INetworkRequestRecordRepository _repository;

    public GetAllNetworkRequestRecordsQueryHandler(INetworkRequestRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<NetworkRequestRecordDto>> Handle(GetAllNetworkRequestRecordsQuery request, CancellationToken cancellationToken)
    {
        var records = await _repository.GetAllAsync(cancellationToken);
        return records.Select(r => r.ToDto());
    }
}
