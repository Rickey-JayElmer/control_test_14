using Control14.Application.DTOs;
using Control14.Domain.Entities;

namespace Control14.Application.Mappings;

public static class OrganizationRecordMappingExtensions
{
    public static OrganizationRecordDto ToDto(this OrganizationRecord record)
    {
        return new OrganizationRecordDto(
            record.Id,
            record.CompanyAddress,
            record.BusinessCity,
            record.BusinessState,
            record.BusinessPostcode,
            record.BusinessCountry,
            record.CompanyName,
            record.SupportEmail,
            record.CorporateContactChannel,
            record.OfficePhone,
            record.OfficeFax,
            record.CorporateWebsite,
            record.BusinessGovId,
            record.VatNumber,
            record.BusinessTaxId,
            record.CompanyRegistrationNumber,
            record.DunsNumber,
            record.LegalEntityIdentifier,
            record.CharityNumber,
            record.IncorporationDetails,
            record.CompanyId,
            record.BusinessEntityName,
            record.CompaniesHouseNumber,
            record.TenantId,
            record.EmployeeWorkEmail,
            record.EmployeeDirectDial,
            record.BusinessTaxReference,
            record.BusinessFullAddress);
    }
}
