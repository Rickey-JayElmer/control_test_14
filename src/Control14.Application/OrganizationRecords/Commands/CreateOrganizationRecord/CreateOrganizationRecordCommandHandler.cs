using Control14.Application.Interfaces;
using Control14.Domain.Entities;
using MediatR;

namespace Control14.Application.OrganizationRecords.Commands.CreateOrganizationRecord;

public class CreateOrganizationRecordCommandHandler : IRequestHandler<CreateOrganizationRecordCommand, Guid>
{
    private readonly IOrganizationRecordRepository _repository;

    public CreateOrganizationRecordCommandHandler(IOrganizationRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateOrganizationRecordCommand request, CancellationToken cancellationToken)
    {
        var record = OrganizationRecord.Create(
            request.CompanyAddress,
            request.BusinessCity,
            request.BusinessState,
            request.BusinessPostcode,
            request.BusinessCountry,
            request.CompanyName,
            request.SupportEmail,
            request.CorporateContactChannel,
            request.OfficePhone,
            request.OfficeFax,
            request.CorporateWebsite,
            request.BusinessGovId,
            request.VatNumber,
            request.BusinessTaxId,
            request.CompanyRegistrationNumber,
            request.DunsNumber,
            request.LegalEntityIdentifier,
            request.CharityNumber,
            request.IncorporationDetails,
            request.CompanyId,
            request.BusinessEntityName,
            request.CompaniesHouseNumber,
            request.TenantId,
            request.EmployeeWorkEmail,
            request.EmployeeDirectDial,
            request.BusinessTaxReference,
            request.BusinessFullAddress);

        await _repository.AddAsync(record, cancellationToken);

        return record.Id;
    }
}
