namespace Control14.Domain.Entities;

public class OrganizationRecord
{
    public Guid Id { get; private set; }
    public string CompanyAddress { get; private set; } = string.Empty;
    public string BusinessCity { get; private set; } = string.Empty;
    public string BusinessState { get; private set; } = string.Empty;
    public string BusinessPostcode { get; private set; } = string.Empty;
    public string BusinessCountry { get; private set; } = string.Empty;
    public string CompanyName { get; private set; } = string.Empty;
    public string SupportEmail { get; private set; } = string.Empty;
    public string CorporateContactChannel { get; private set; } = string.Empty;
    public string OfficePhone { get; private set; } = string.Empty;
    public string OfficeFax { get; private set; } = string.Empty;
    public string CorporateWebsite { get; private set; } = string.Empty;
    public string BusinessGovId { get; private set; } = string.Empty;
    public string VatNumber { get; private set; } = string.Empty;
    public string BusinessTaxId { get; private set; } = string.Empty;
    public string CompanyRegistrationNumber { get; private set; } = string.Empty;
    public string DunsNumber { get; private set; } = string.Empty;
    public string LegalEntityIdentifier { get; private set; } = string.Empty;
    public string CharityNumber { get; private set; } = string.Empty;
    public string IncorporationDetails { get; private set; } = string.Empty;
    public string CompanyId { get; private set; } = string.Empty;
    public string BusinessEntityName { get; private set; } = string.Empty;
    public string CompaniesHouseNumber { get; private set; } = string.Empty;
    public string TenantId { get; private set; } = string.Empty;
    public string EmployeeWorkEmail { get; private set; } = string.Empty;
    public string EmployeeDirectDial { get; private set; } = string.Empty;
    public string BusinessTaxReference { get; private set; } = string.Empty;
    public string BusinessFullAddress { get; private set; } = string.Empty;

    private OrganizationRecord() { }

    public static OrganizationRecord Create(
        string companyAddress,
        string businessCity,
        string businessState,
        string businessPostcode,
        string businessCountry,
        string companyName,
        string supportEmail,
        string corporateContactChannel,
        string officePhone,
        string officeFax,
        string corporateWebsite,
        string businessGovId,
        string vatNumber,
        string businessTaxId,
        string companyRegistrationNumber,
        string dunsNumber,
        string legalEntityIdentifier,
        string charityNumber,
        string incorporationDetails,
        string companyId,
        string businessEntityName,
        string companiesHouseNumber,
        string tenantId,
        string employeeWorkEmail,
        string employeeDirectDial,
        string businessTaxReference,
        string businessFullAddress)
    {
        return new OrganizationRecord
        {
            Id = Guid.NewGuid(),
            CompanyAddress = companyAddress,
            BusinessCity = businessCity,
            BusinessState = businessState,
            BusinessPostcode = businessPostcode,
            BusinessCountry = businessCountry,
            CompanyName = companyName,
            SupportEmail = supportEmail,
            CorporateContactChannel = corporateContactChannel,
            OfficePhone = officePhone,
            OfficeFax = officeFax,
            CorporateWebsite = corporateWebsite,
            BusinessGovId = businessGovId,
            VatNumber = vatNumber,
            BusinessTaxId = businessTaxId,
            CompanyRegistrationNumber = companyRegistrationNumber,
            DunsNumber = dunsNumber,
            LegalEntityIdentifier = legalEntityIdentifier,
            CharityNumber = charityNumber,
            IncorporationDetails = incorporationDetails,
            CompanyId = companyId,
            BusinessEntityName = businessEntityName,
            CompaniesHouseNumber = companiesHouseNumber,
            TenantId = tenantId,
            EmployeeWorkEmail = employeeWorkEmail,
            EmployeeDirectDial = employeeDirectDial,
            BusinessTaxReference = businessTaxReference,
            BusinessFullAddress = businessFullAddress
        };
    }

    public void Update(
        string companyAddress,
        string businessCity,
        string businessState,
        string businessPostcode,
        string businessCountry,
        string companyName,
        string supportEmail,
        string corporateContactChannel,
        string officePhone,
        string officeFax,
        string corporateWebsite,
        string businessGovId,
        string vatNumber,
        string businessTaxId,
        string companyRegistrationNumber,
        string dunsNumber,
        string legalEntityIdentifier,
        string charityNumber,
        string incorporationDetails,
        string companyId,
        string businessEntityName,
        string companiesHouseNumber,
        string tenantId,
        string employeeWorkEmail,
        string employeeDirectDial,
        string businessTaxReference,
        string businessFullAddress)
    {
        CompanyAddress = companyAddress;
        BusinessCity = businessCity;
        BusinessState = businessState;
        BusinessPostcode = businessPostcode;
        BusinessCountry = businessCountry;
        CompanyName = companyName;
        SupportEmail = supportEmail;
        CorporateContactChannel = corporateContactChannel;
        OfficePhone = officePhone;
        OfficeFax = officeFax;
        CorporateWebsite = corporateWebsite;
        BusinessGovId = businessGovId;
        VatNumber = vatNumber;
        BusinessTaxId = businessTaxId;
        CompanyRegistrationNumber = companyRegistrationNumber;
        DunsNumber = dunsNumber;
        LegalEntityIdentifier = legalEntityIdentifier;
        CharityNumber = charityNumber;
        IncorporationDetails = incorporationDetails;
        CompanyId = companyId;
        BusinessEntityName = businessEntityName;
        CompaniesHouseNumber = companiesHouseNumber;
        TenantId = tenantId;
        EmployeeWorkEmail = employeeWorkEmail;
        EmployeeDirectDial = employeeDirectDial;
        BusinessTaxReference = businessTaxReference;
        BusinessFullAddress = businessFullAddress;
    }
}
