using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.PersonalRecords.Commands.UpdatePersonalRecord;

public class UpdatePersonalRecordCommandHandler : IRequestHandler<UpdatePersonalRecordCommand, PersonalRecordDto?>
{
    private readonly IPersonalRecordRepository _repository;

    public UpdatePersonalRecordCommandHandler(IPersonalRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<PersonalRecordDto?> Handle(UpdatePersonalRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return null;

        record.Update(
            request.HomeAddress,
            request.City,
            request.StateProvince,
            request.ZipCode,
            request.Country,
            request.FullName,
            request.MaidenName,
            request.Gender,
            request.Nationality,
            request.Ethnicity,
            request.Religion,
            request.PoliticalParty,
            request.SexualOrientation,
            request.Caste,
            request.TribalAffiliation,
            request.PreferredLanguage,
            request.UserEmail,
            request.PersonalContactChannel,
            request.MobilePhone,
            request.PersonalFax,
            request.PersonalBlogUrl,
            request.EmergencyContact,
            request.TwitterHandle,
            request.GovernmentIdNumber,
            request.PassportNumber,
            request.DriverLicenseNumber,
            request.Ssn,
            request.VisaNumber,
            request.MilitaryServiceNumber,
            request.VoterId,
            request.BenefitsId,
            request.LicensePlate,
            request.IndividualTaxId,
            request.MaritalStatus,
            request.BirthCertificateNumber,
            request.Age,
            request.AgeBand,
            request.PlaceOfBirth,
            request.Dob,
            request.FingerprintTemplate,
            request.UserId,
            request.DiplomaReference,
            request.CourseCode,
            request.AcademicTerm,
            request.EnrolmentStatus,
            request.EnrolmentDate,
            request.WithdrawalDate,
            request.GradYear,
            request.ExamGrade,
            request.CumulativeGpa,
            request.AcademicStanding,
            request.AttendanceRecord,
            request.ExamSitting,
            request.ThesisTitle,
            request.AdvisorName,
            request.TuitionFee,
            request.FeeResidencyStatus,
            request.ScholarshipAward,
            request.SenSupportPlan,
            request.AcademicMisconductRecord,
            request.ClubMembership,
            request.SchoolName,
            request.ChatThreadId,
            request.ChatMessageBody,
            request.SmsBody,
            request.PushPayload,
            request.VoicemailAudio,
            request.CallRecordingBlob,
            request.CallMetadata,
            request.CallTranscript,
            request.DisabilityStatus,
            request.MedicalRecord,
            request.MedicalCondition,
            request.IcdCode,
            request.SymptomText,
            request.PrescriptionDrug,
            request.TreatmentPlan,
            request.ClinicalLetter,
            request.PatientVisitRecord,
            request.AppointmentBooking,
            request.SurgeryRecord,
            request.VaccinationRecord,
            request.AllergyInfo,
            request.MentalHealthScreening,
            request.PacemakerSerial,
            request.DnaTestResult,
            request.FertilityRecord,
            request.PregnancyStatus,
            request.SmokingStatus,
            request.UnionMembership,
            request.CaregiverStatus,
            request.PrimaryEmail,
            request.ContactEmailAddress,
            request.Cellphone,
            request.Msisdn,
            request.CustomerName,
            request.FullLegalName,
            request.StreetAddressLine1,
            request.ResidentialAddress,
            request.BirthDate,
            request.DateOfBirth,
            request.CustomerId,
            request.AccountId,
            request.MemberId,
            request.SocialSecurityNumber,
            request.PassportNo,
            request.DriversLicense,
            request.Itin,
            request.GenderIdentity,
            request.CitizenshipCountry,
            request.CityOfBirth,
            request.SupervisorFullName,
            request.UserPostcode,
            request.CustomerCity,
            request.UserCountryOfResidence,
            request.CustomerDob,
            request.NationalInsuranceNumber,
            request.CustomerLoginEmail,
            request.OtpDeliveryPhone,
            request.PassportBioPage,
            request.DriversLicenseImage,
            request.BirthCertificateScan,
            request.DischargeSummary,
            request.FullPostalAddress,
            request.CustomerProfileJson);

        await _repository.UpdateAsync(record, cancellationToken);

        return record.ToDto();
    }
}
