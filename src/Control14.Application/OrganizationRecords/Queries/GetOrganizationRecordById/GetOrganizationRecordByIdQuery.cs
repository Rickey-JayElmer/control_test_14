using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.OrganizationRecords.Queries.GetOrganizationRecordById;

public record GetOrganizationRecordByIdQuery(Guid Id) : IRequest<OrganizationRecordDto?>;
