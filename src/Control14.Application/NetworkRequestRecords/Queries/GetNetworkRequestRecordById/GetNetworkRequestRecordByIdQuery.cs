using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.NetworkRequestRecords.Queries.GetNetworkRequestRecordById;

public record GetNetworkRequestRecordByIdQuery(Guid Id) : IRequest<NetworkRequestRecordDto?>;
