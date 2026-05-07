using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.OrganizationRecords.Queries.GetAllOrganizationRecords;

public record GetAllOrganizationRecordsQuery() : IRequest<IEnumerable<OrganizationRecordDto>>;
