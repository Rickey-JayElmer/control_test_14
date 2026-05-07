using System.Text.Json.Serialization;

namespace Control14.Application.DTOs;

public record OrganizationRecordDto(
    Guid Id,
    [property: JsonPropertyName("company_address")] string CompanyAddress,
    [property: JsonPropertyName("business_city")] string BusinessCity,
    [property: JsonPropertyName("business_state")] string BusinessState,
    [property: JsonPropertyName("business_postcode")] string BusinessPostcode,
    [property: JsonPropertyName("business_country")] string BusinessCountry,
    [property: JsonPropertyName("company_name")] string CompanyName,
    [property: JsonPropertyName("support_email")] string SupportEmail,
    [property: JsonPropertyName("corporate_contact_channel")] string CorporateContactChannel,
    [property: JsonPropertyName("office_phone")] string OfficePhone,
    [property: JsonPropertyName("office_fax")] string OfficeFax,
    [property: JsonPropertyName("corporate_website")] string CorporateWebsite,
    [property: JsonPropertyName("business_gov_id")] string BusinessGovId,
    [property: JsonPropertyName("vat_number")] string VatNumber,
    [property: JsonPropertyName("business_tax_id")] string BusinessTaxId,
    [property: JsonPropertyName("company_registration_number")] string CompanyRegistrationNumber,
    [property: JsonPropertyName("duns_number")] string DunsNumber,
    [property: JsonPropertyName("legal_entity_identifier")] string LegalEntityIdentifier,
    [property: JsonPropertyName("charity_number")] string CharityNumber,
    [property: JsonPropertyName("incorporation_details")] string IncorporationDetails,
    [property: JsonPropertyName("company_id")] string CompanyId,
    [property: JsonPropertyName("business_entity_name")] string BusinessEntityName,
    [property: JsonPropertyName("companies_house_number")] string CompaniesHouseNumber,
    [property: JsonPropertyName("tenantId")] string TenantId,
    [property: JsonPropertyName("employee_work_email")] string EmployeeWorkEmail,
    [property: JsonPropertyName("employee_direct_dial")] string EmployeeDirectDial,
    [property: JsonPropertyName("business_tax_reference")] string BusinessTaxReference,
    [property: JsonPropertyName("business_full_address")] string BusinessFullAddress);
