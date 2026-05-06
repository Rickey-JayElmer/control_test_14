using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.NetworkRequestRecords.Queries.GetAllNetworkRequestRecords;

public record GetAllNetworkRequestRecordsQuery() : IRequest<IEnumerable<NetworkRequestRecordDto>>;
