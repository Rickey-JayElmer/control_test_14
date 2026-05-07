namespace Control14.Domain.Entities;

public class PersonalRecord
{
    public Guid Id { get; private set; }
    public string HomeAddress { get; private set; } = string.Empty;
    public string City { get; private set; } = string.Empty;
    public string StateProvince { get; private set; } = string.Empty;
    public string ZipCode { get; private set; } = string.Empty;
    public string Country { get; private set; } = string.Empty;
    public string FullName { get; private set; } = string.Empty;
    public string MaidenName { get; private set; } = string.Empty;
    public string Gender { get; private set; } = string.Empty;
    public string Nationality { get; private set; } = string.Empty;
    public string Ethnicity { get; private set; } = string.Empty;
    public string Religion { get; private set; } = string.Empty;
    public string PoliticalParty { get; private set; } = string.Empty;
    public string SexualOrientation { get; private set; } = string.Empty;
    public string Caste { get; private set; } = string.Empty;
    public string TribalAffiliation { get; private set; } = string.Empty;
    public string PreferredLanguage { get; private set; } = string.Empty;
    public string UserEmail { get; private set; } = string.Empty;
    public string PersonalContactChannel { get; private set; } = string.Empty;
    public string MobilePhone { get; private set; } = string.Empty;
    public string PersonalFax { get; private set; } = string.Empty;
    public string PersonalBlogUrl { get; private set; } = string.Empty;
    public string EmergencyContact { get; private set; } = string.Empty;
    public string TwitterHandle { get; private set; } = string.Empty;
    public string GovernmentIdNumber { get; private set; } = string.Empty;
    public string PassportNumber { get; private set; } = string.Empty;
    public string DriverLicenseNumber { get; private set; } = string.Empty;
    public string Ssn { get; private set; } = string.Empty;
    public string VisaNumber { get; private set; } = string.Empty;
    public string MilitaryServiceNumber { get; private set; } = string.Empty;
    public string VoterId { get; private set; } = string.Empty;
    public string BenefitsId { get; private set; } = string.Empty;
    public string LicensePlate { get; private set; } = string.Empty;
    public string IndividualTaxId { get; private set; } = string.Empty;
    public string MaritalStatus { get; private set; } = string.Empty;
    public string BirthCertificateNumber { get; private set; } = string.Empty;
    public double Age { get; private set; }
    public string AgeBand { get; private set; } = string.Empty;
    public string PlaceOfBirth { get; private set; } = string.Empty;
    public string Dob { get; private set; } = string.Empty;
    public string FingerprintTemplate { get; private set; } = string.Empty;
    public string UserId { get; private set; } = string.Empty;
    public string DiplomaReference { get; private set; } = string.Empty;
    public string CourseCode { get; private set; } = string.Empty;
    public string AcademicTerm { get; private set; } = string.Empty;
    public string EnrolmentStatus { get; private set; } = string.Empty;
    public string EnrolmentDate { get; private set; } = string.Empty;
    public string WithdrawalDate { get; private set; } = string.Empty;
    public string GradYear { get; private set; } = string.Empty;
    public string ExamGrade { get; private set; } = string.Empty;
    public double CumulativeGpa { get; private set; }
    public string AcademicStanding { get; private set; } = string.Empty;
    public string AttendanceRecord { get; private set; } = string.Empty;
    public string ExamSitting { get; private set; } = string.Empty;
    public string ThesisTitle { get; private set; } = string.Empty;
    public string AdvisorName { get; private set; } = string.Empty;
    public double TuitionFee { get; private set; }
    public string FeeResidencyStatus { get; private set; } = string.Empty;
    public double ScholarshipAward { get; private set; }
    public string SenSupportPlan { get; private set; } = string.Empty;
    public string AcademicMisconductRecord { get; private set; } = string.Empty;
    public string ClubMembership { get; private set; } = string.Empty;
    public string SchoolName { get; private set; } = string.Empty;
    public string ChatThreadId { get; private set; } = string.Empty;
    public string ChatMessageBody { get; private set; } = string.Empty;
    public string SmsBody { get; private set; } = string.Empty;
    public string PushPayload { get; private set; } = string.Empty;
    public string VoicemailAudio { get; private set; } = string.Empty;
    public string CallRecordingBlob { get; private set; } = string.Empty;
    public string CallMetadata { get; private set; } = string.Empty;
    public string CallTranscript { get; private set; } = string.Empty;
    public string DisabilityStatus { get; private set; } = string.Empty;
    public string MedicalRecord { get; private set; } = string.Empty;
    public string MedicalCondition { get; private set; } = string.Empty;
    public string IcdCode { get; private set; } = string.Empty;
    public string SymptomText { get; private set; } = string.Empty;
    public string PrescriptionDrug { get; private set; } = string.Empty;
    public string TreatmentPlan { get; private set; } = string.Empty;
    public string ClinicalLetter { get; private set; } = string.Empty;
    public string PatientVisitRecord { get; private set; } = string.Empty;
    public string AppointmentBooking { get; private set; } = string.Empty;
    public string SurgeryRecord { get; private set; } = string.Empty;
    public string VaccinationRecord { get; private set; } = string.Empty;
    public string AllergyInfo { get; private set; } = string.Empty;
    public string MentalHealthScreening { get; private set; } = string.Empty;
    public string PacemakerSerial { get; private set; } = string.Empty;
    public string DnaTestResult { get; private set; } = string.Empty;
    public string FertilityRecord { get; private set; } = string.Empty;
    public string PregnancyStatus { get; private set; } = string.Empty;
    public string SmokingStatus { get; private set; } = string.Empty;
    public string UnionMembership { get; private set; } = string.Empty;
    public string CaregiverStatus { get; private set; } = string.Empty;
    public string PrimaryEmail { get; private set; } = string.Empty;
    public string ContactEmailAddress { get; private set; } = string.Empty;
    public string Cellphone { get; private set; } = string.Empty;
    public string Msisdn { get; private set; } = string.Empty;
    public string CustomerName { get; private set; } = string.Empty;
    public string FullLegalName { get; private set; } = string.Empty;
    public string StreetAddressLine1 { get; private set; } = string.Empty;
    public string ResidentialAddress { get; private set; } = string.Empty;
    public string BirthDate { get; private set; } = string.Empty;
    public string DateOfBirth { get; private set; } = string.Empty;
    public string CustomerId { get; private set; } = string.Empty;
    public string AccountId { get; private set; } = string.Empty;
    public string MemberId { get; private set; } = string.Empty;
    public string SocialSecurityNumber { get; private set; } = string.Empty;
    public string PassportNo { get; private set; } = string.Empty;
    public string DriversLicense { get; private set; } = string.Empty;
    public string Itin { get; private set; } = string.Empty;
    public string GenderIdentity { get; private set; } = string.Empty;
    public string CitizenshipCountry { get; private set; } = string.Empty;
    public string CityOfBirth { get; private set; } = string.Empty;
    public string SupervisorFullName { get; private set; } = string.Empty;
    public string UserPostcode { get; private set; } = string.Empty;
    public string CustomerCity { get; private set; } = string.Empty;
    public string UserCountryOfResidence { get; private set; } = string.Empty;
    public string CustomerDob { get; private set; } = string.Empty;
    public string NationalInsuranceNumber { get; private set; } = string.Empty;
    public string CustomerLoginEmail { get; private set; } = string.Empty;
    public string OtpDeliveryPhone { get; private set; } = string.Empty;
    public string PassportBioPage { get; private set; } = string.Empty;
    public string DriversLicenseImage { get; private set; } = string.Empty;
    public string BirthCertificateScan { get; private set; } = string.Empty;
    public string DischargeSummary { get; private set; } = string.Empty;
    public string FullPostalAddress { get; private set; } = string.Empty;
    public string CustomerProfileJson { get; private set; } = string.Empty;

    private PersonalRecord() { }

    public static PersonalRecord Create(
        string homeAddress,
        string city,
        string stateProvince,
        string zipCode,
        string country,
        string fullName,
        string maidenName,
        string gender,
        string nationality,
        string ethnicity,
        string religion,
        string politicalParty,
        string sexualOrientation,
        string caste,
        string tribalAffiliation,
        string preferredLanguage,
        string userEmail,
        string personalContactChannel,
        string mobilePhone,
        string personalFax,
        string personalBlogUrl,
        string emergencyContact,
        string twitterHandle,
        string governmentIdNumber,
        string passportNumber,
        string driverLicenseNumber,
        string ssn,
        string visaNumber,
        string militaryServiceNumber,
        string voterId,
        string benefitsId,
        string licensePlate,
        string individualTaxId,
        string maritalStatus,
        string birthCertificateNumber,
        double age,
        string ageBand,
        string placeOfBirth,
        string dob,
        string fingerprintTemplate,
        string userId,
        string diplomaReference,
        string courseCode,
        string academicTerm,
        string enrolmentStatus,
        string enrolmentDate,
        string withdrawalDate,
        string gradYear,
        string examGrade,
        double cumulativeGpa,
        string academicStanding,
        string attendanceRecord,
        string examSitting,
        string thesisTitle,
        string advisorName,
        double tuitionFee,
        string feeResidencyStatus,
        double scholarshipAward,
        string senSupportPlan,
        string academicMisconductRecord,
        string clubMembership,
        string schoolName,
        string chatThreadId,
        string chatMessageBody,
        string smsBody,
        string pushPayload,
        string voicemailAudio,
        string callRecordingBlob,
        string callMetadata,
        string callTranscript,
        string disabilityStatus,
        string medicalRecord,
        string medicalCondition,
        string icdCode,
        string symptomText,
        string prescriptionDrug,
        string treatmentPlan,
        string clinicalLetter,
        string patientVisitRecord,
        string appointmentBooking,
        string surgeryRecord,
        string vaccinationRecord,
        string allergyInfo,
        string mentalHealthScreening,
        string pacemakerSerial,
        string dnaTestResult,
        string fertilityRecord,
        string pregnancyStatus,
        string smokingStatus,
        string unionMembership,
        string caregiverStatus,
        string primaryEmail,
        string contactEmailAddress,
        string cellphone,
        string msisdn,
        string customerName,
        string fullLegalName,
        string streetAddressLine1,
        string residentialAddress,
        string birthDate,
        string dateOfBirth,
        string customerId,
        string accountId,
        string memberId,
        string socialSecurityNumber,
        string passportNo,
        string driversLicense,
        string itin,
        string genderIdentity,
        string citizenshipCountry,
        string cityOfBirth,
        string supervisorFullName,
        string userPostcode,
        string customerCity,
        string userCountryOfResidence,
        string customerDob,
        string nationalInsuranceNumber,
        string customerLoginEmail,
        string otpDeliveryPhone,
        string passportBioPage,
        string driversLicenseImage,
        string birthCertificateScan,
        string dischargeSummary,
        string fullPostalAddress,
        string customerProfileJson)
    {
        return new PersonalRecord
        {
            Id = Guid.NewGuid(),
            HomeAddress = homeAddress,
            City = city,
            StateProvince = stateProvince,
            ZipCode = zipCode,
            Country = country,
            FullName = fullName,
            MaidenName = maidenName,
            Gender = gender,
            Nationality = nationality,
            Ethnicity = ethnicity,
            Religion = religion,
            PoliticalParty = politicalParty,
            SexualOrientation = sexualOrientation,
            Caste = caste,
            TribalAffiliation = tribalAffiliation,
            PreferredLanguage = preferredLanguage,
            UserEmail = userEmail,
            PersonalContactChannel = personalContactChannel,
            MobilePhone = mobilePhone,
            PersonalFax = personalFax,
            PersonalBlogUrl = personalBlogUrl,
            EmergencyContact = emergencyContact,
            TwitterHandle = twitterHandle,
            GovernmentIdNumber = governmentIdNumber,
            PassportNumber = passportNumber,
            DriverLicenseNumber = driverLicenseNumber,
            Ssn = ssn,
            VisaNumber = visaNumber,
            MilitaryServiceNumber = militaryServiceNumber,
            VoterId = voterId,
            BenefitsId = benefitsId,
            LicensePlate = licensePlate,
            IndividualTaxId = individualTaxId,
            MaritalStatus = maritalStatus,
            BirthCertificateNumber = birthCertificateNumber,
            Age = age,
            AgeBand = ageBand,
            PlaceOfBirth = placeOfBirth,
            Dob = dob,
            FingerprintTemplate = fingerprintTemplate,
            UserId = userId,
            DiplomaReference = diplomaReference,
            CourseCode = courseCode,
            AcademicTerm = academicTerm,
            EnrolmentStatus = enrolmentStatus,
            EnrolmentDate = enrolmentDate,
            WithdrawalDate = withdrawalDate,
            GradYear = gradYear,
            ExamGrade = examGrade,
            CumulativeGpa = cumulativeGpa,
            AcademicStanding = academicStanding,
            AttendanceRecord = attendanceRecord,
            ExamSitting = examSitting,
            ThesisTitle = thesisTitle,
            AdvisorName = advisorName,
            TuitionFee = tuitionFee,
            FeeResidencyStatus = feeResidencyStatus,
            ScholarshipAward = scholarshipAward,
            SenSupportPlan = senSupportPlan,
            AcademicMisconductRecord = academicMisconductRecord,
            ClubMembership = clubMembership,
            SchoolName = schoolName,
            ChatThreadId = chatThreadId,
            ChatMessageBody = chatMessageBody,
            SmsBody = smsBody,
            PushPayload = pushPayload,
            VoicemailAudio = voicemailAudio,
            CallRecordingBlob = callRecordingBlob,
            CallMetadata = callMetadata,
            CallTranscript = callTranscript,
            DisabilityStatus = disabilityStatus,
            MedicalRecord = medicalRecord,
            MedicalCondition = medicalCondition,
            IcdCode = icdCode,
            SymptomText = symptomText,
            PrescriptionDrug = prescriptionDrug,
            TreatmentPlan = treatmentPlan,
            ClinicalLetter = clinicalLetter,
            PatientVisitRecord = patientVisitRecord,
            AppointmentBooking = appointmentBooking,
            SurgeryRecord = surgeryRecord,
            VaccinationRecord = vaccinationRecord,
            AllergyInfo = allergyInfo,
            MentalHealthScreening = mentalHealthScreening,
            PacemakerSerial = pacemakerSerial,
            DnaTestResult = dnaTestResult,
            FertilityRecord = fertilityRecord,
            PregnancyStatus = pregnancyStatus,
            SmokingStatus = smokingStatus,
            UnionMembership = unionMembership,
            CaregiverStatus = caregiverStatus,
            PrimaryEmail = primaryEmail,
            ContactEmailAddress = contactEmailAddress,
            Cellphone = cellphone,
            Msisdn = msisdn,
            CustomerName = customerName,
            FullLegalName = fullLegalName,
            StreetAddressLine1 = streetAddressLine1,
            ResidentialAddress = residentialAddress,
            BirthDate = birthDate,
            DateOfBirth = dateOfBirth,
            CustomerId = customerId,
            AccountId = accountId,
            MemberId = memberId,
            SocialSecurityNumber = socialSecurityNumber,
            PassportNo = passportNo,
            DriversLicense = driversLicense,
            Itin = itin,
            GenderIdentity = genderIdentity,
            CitizenshipCountry = citizenshipCountry,
            CityOfBirth = cityOfBirth,
            SupervisorFullName = supervisorFullName,
            UserPostcode = userPostcode,
            CustomerCity = customerCity,
            UserCountryOfResidence = userCountryOfResidence,
            CustomerDob = customerDob,
            NationalInsuranceNumber = nationalInsuranceNumber,
            CustomerLoginEmail = customerLoginEmail,
            OtpDeliveryPhone = otpDeliveryPhone,
            PassportBioPage = passportBioPage,
            DriversLicenseImage = driversLicenseImage,
            BirthCertificateScan = birthCertificateScan,
            DischargeSummary = dischargeSummary,
            FullPostalAddress = fullPostalAddress,
            CustomerProfileJson = customerProfileJson
        };
    }

    public void Update(
        string homeAddress,
        string city,
        string stateProvince,
        string zipCode,
        string country,
        string fullName,
        string maidenName,
        string gender,
        string nationality,
        string ethnicity,
        string religion,
        string politicalParty,
        string sexualOrientation,
        string caste,
        string tribalAffiliation,
        string preferredLanguage,
        string userEmail,
        string personalContactChannel,
        string mobilePhone,
        string personalFax,
        string personalBlogUrl,
        string emergencyContact,
        string twitterHandle,
        string governmentIdNumber,
        string passportNumber,
        string driverLicenseNumber,
        string ssn,
        string visaNumber,
        string militaryServiceNumber,
        string voterId,
        string benefitsId,
        string licensePlate,
        string individualTaxId,
        string maritalStatus,
        string birthCertificateNumber,
        double age,
        string ageBand,
        string placeOfBirth,
        string dob,
        string fingerprintTemplate,
        string userId,
        string diplomaReference,
        string courseCode,
        string academicTerm,
        string enrolmentStatus,
        string enrolmentDate,
        string withdrawalDate,
        string gradYear,
        string examGrade,
        double cumulativeGpa,
        string academicStanding,
        string attendanceRecord,
        string examSitting,
        string thesisTitle,
        string advisorName,
        double tuitionFee,
        string feeResidencyStatus,
        double scholarshipAward,
        string senSupportPlan,
        string academicMisconductRecord,
        string clubMembership,
        string schoolName,
        string chatThreadId,
        string chatMessageBody,
        string smsBody,
        string pushPayload,
        string voicemailAudio,
        string callRecordingBlob,
        string callMetadata,
        string callTranscript,
        string disabilityStatus,
        string medicalRecord,
        string medicalCondition,
        string icdCode,
        string symptomText,
        string prescriptionDrug,
        string treatmentPlan,
        string clinicalLetter,
        string patientVisitRecord,
        string appointmentBooking,
        string surgeryRecord,
        string vaccinationRecord,
        string allergyInfo,
        string mentalHealthScreening,
        string pacemakerSerial,
        string dnaTestResult,
        string fertilityRecord,
        string pregnancyStatus,
        string smokingStatus,
        string unionMembership,
        string caregiverStatus,
        string primaryEmail,
        string contactEmailAddress,
        string cellphone,
        string msisdn,
        string customerName,
        string fullLegalName,
        string streetAddressLine1,
        string residentialAddress,
        string birthDate,
        string dateOfBirth,
        string customerId,
        string accountId,
        string memberId,
        string socialSecurityNumber,
        string passportNo,
        string driversLicense,
        string itin,
        string genderIdentity,
        string citizenshipCountry,
        string cityOfBirth,
        string supervisorFullName,
        string userPostcode,
        string customerCity,
        string userCountryOfResidence,
        string customerDob,
        string nationalInsuranceNumber,
        string customerLoginEmail,
        string otpDeliveryPhone,
        string passportBioPage,
        string driversLicenseImage,
        string birthCertificateScan,
        string dischargeSummary,
        string fullPostalAddress,
        string customerProfileJson)
    {
        HomeAddress = homeAddress;
        City = city;
        StateProvince = stateProvince;
        ZipCode = zipCode;
        Country = country;
        FullName = fullName;
        MaidenName = maidenName;
        Gender = gender;
        Nationality = nationality;
        Ethnicity = ethnicity;
        Religion = religion;
        PoliticalParty = politicalParty;
        SexualOrientation = sexualOrientation;
        Caste = caste;
        TribalAffiliation = tribalAffiliation;
        PreferredLanguage = preferredLanguage;
        UserEmail = userEmail;
        PersonalContactChannel = personalContactChannel;
        MobilePhone = mobilePhone;
        PersonalFax = personalFax;
        PersonalBlogUrl = personalBlogUrl;
        EmergencyContact = emergencyContact;
        TwitterHandle = twitterHandle;
        GovernmentIdNumber = governmentIdNumber;
        PassportNumber = passportNumber;
        DriverLicenseNumber = driverLicenseNumber;
        Ssn = ssn;
        VisaNumber = visaNumber;
        MilitaryServiceNumber = militaryServiceNumber;
        VoterId = voterId;
        BenefitsId = benefitsId;
        LicensePlate = licensePlate;
        IndividualTaxId = individualTaxId;
        MaritalStatus = maritalStatus;
        BirthCertificateNumber = birthCertificateNumber;
        Age = age;
        AgeBand = ageBand;
        PlaceOfBirth = placeOfBirth;
        Dob = dob;
        FingerprintTemplate = fingerprintTemplate;
        UserId = userId;
        DiplomaReference = diplomaReference;
        CourseCode = courseCode;
        AcademicTerm = academicTerm;
        EnrolmentStatus = enrolmentStatus;
        EnrolmentDate = enrolmentDate;
        WithdrawalDate = withdrawalDate;
        GradYear = gradYear;
        ExamGrade = examGrade;
        CumulativeGpa = cumulativeGpa;
        AcademicStanding = academicStanding;
        AttendanceRecord = attendanceRecord;
        ExamSitting = examSitting;
        ThesisTitle = thesisTitle;
        AdvisorName = advisorName;
        TuitionFee = tuitionFee;
        FeeResidencyStatus = feeResidencyStatus;
        ScholarshipAward = scholarshipAward;
        SenSupportPlan = senSupportPlan;
        AcademicMisconductRecord = academicMisconductRecord;
        ClubMembership = clubMembership;
        SchoolName = schoolName;
        ChatThreadId = chatThreadId;
        ChatMessageBody = chatMessageBody;
        SmsBody = smsBody;
        PushPayload = pushPayload;
        VoicemailAudio = voicemailAudio;
        CallRecordingBlob = callRecordingBlob;
        CallMetadata = callMetadata;
        CallTranscript = callTranscript;
        DisabilityStatus = disabilityStatus;
        MedicalRecord = medicalRecord;
        MedicalCondition = medicalCondition;
        IcdCode = icdCode;
        SymptomText = symptomText;
        PrescriptionDrug = prescriptionDrug;
        TreatmentPlan = treatmentPlan;
        ClinicalLetter = clinicalLetter;
        PatientVisitRecord = patientVisitRecord;
        AppointmentBooking = appointmentBooking;
        SurgeryRecord = surgeryRecord;
        VaccinationRecord = vaccinationRecord;
        AllergyInfo = allergyInfo;
        MentalHealthScreening = mentalHealthScreening;
        PacemakerSerial = pacemakerSerial;
        DnaTestResult = dnaTestResult;
        FertilityRecord = fertilityRecord;
        PregnancyStatus = pregnancyStatus;
        SmokingStatus = smokingStatus;
        UnionMembership = unionMembership;
        CaregiverStatus = caregiverStatus;
        PrimaryEmail = primaryEmail;
        ContactEmailAddress = contactEmailAddress;
        Cellphone = cellphone;
        Msisdn = msisdn;
        CustomerName = customerName;
        FullLegalName = fullLegalName;
        StreetAddressLine1 = streetAddressLine1;
        ResidentialAddress = residentialAddress;
        BirthDate = birthDate;
        DateOfBirth = dateOfBirth;
        CustomerId = customerId;
        AccountId = accountId;
        MemberId = memberId;
        SocialSecurityNumber = socialSecurityNumber;
        PassportNo = passportNo;
        DriversLicense = driversLicense;
        Itin = itin;
        GenderIdentity = genderIdentity;
        CitizenshipCountry = citizenshipCountry;
        CityOfBirth = cityOfBirth;
        SupervisorFullName = supervisorFullName;
        UserPostcode = userPostcode;
        CustomerCity = customerCity;
        UserCountryOfResidence = userCountryOfResidence;
        CustomerDob = customerDob;
        NationalInsuranceNumber = nationalInsuranceNumber;
        CustomerLoginEmail = customerLoginEmail;
        OtpDeliveryPhone = otpDeliveryPhone;
        PassportBioPage = passportBioPage;
        DriversLicenseImage = driversLicenseImage;
        BirthCertificateScan = birthCertificateScan;
        DischargeSummary = dischargeSummary;
        FullPostalAddress = fullPostalAddress;
        CustomerProfileJson = customerProfileJson;
    }
}
