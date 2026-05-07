using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.OrganizationRecords.Commands.UpdateOrganizationRecord;

public class UpdateOrganizationRecordCommandHandler : IRequestHandler<UpdateOrganizationRecordCommand, OrganizationRecordDto?>
{
    private readonly IOrganizationRecordRepository _repository;

    public UpdateOrganizationRecordCommandHandler(IOrganizationRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<OrganizationRecordDto?> Handle(UpdateOrganizationRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return null;

        record.Update(
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

        await _repository.UpdateAsync(record, cancellationToken);

        return record.ToDto();
    }
}
