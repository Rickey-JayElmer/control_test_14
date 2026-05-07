namespace Control14.Domain.Entities;

public class HrRecord
{
    public Guid Id { get; private set; }
    public double BaseSalaryAmount { get; private set; }
    public double AnnualBonusAmount { get; private set; }
    public double OvertimePay { get; private set; }
    public double EquityGrantUnits { get; private set; }
    public string BenefitsEnrolment { get; private set; } = string.Empty;
    public double PensionContributionAmount { get; private set; }
    public string HireDate { get; private set; } = string.Empty;
    public string JobTitle { get; private set; } = string.Empty;
    public string EmploymentStatus { get; private set; } = string.Empty;
    public string DisciplinaryRecord { get; private set; } = string.Empty;
    public double LeaveBalance { get; private set; }
    public string PayslipPdf { get; private set; } = string.Empty;
    public string EmployeePersonnelRecord { get; private set; } = string.Empty;

    private HrRecord() { }

    public static HrRecord Create(
        double baseSalaryAmount,
        double annualBonusAmount,
        double overtimePay,
        double equityGrantUnits,
        string benefitsEnrolment,
        double pensionContributionAmount,
        string hireDate,
        string jobTitle,
        string employmentStatus,
        string disciplinaryRecord,
        double leaveBalance,
        string payslipPdf,
        string employeePersonnelRecord)
    {
        return new HrRecord
        {
            Id = Guid.NewGuid(),
            BaseSalaryAmount = baseSalaryAmount,
            AnnualBonusAmount = annualBonusAmount,
            OvertimePay = overtimePay,
            EquityGrantUnits = equityGrantUnits,
            BenefitsEnrolment = benefitsEnrolment,
            PensionContributionAmount = pensionContributionAmount,
            HireDate = hireDate,
            JobTitle = jobTitle,
            EmploymentStatus = employmentStatus,
            DisciplinaryRecord = disciplinaryRecord,
            LeaveBalance = leaveBalance,
            PayslipPdf = payslipPdf,
            EmployeePersonnelRecord = employeePersonnelRecord
        };
    }

    public void Update(
        double baseSalaryAmount,
        double annualBonusAmount,
        double overtimePay,
        double equityGrantUnits,
        string benefitsEnrolment,
        double pensionContributionAmount,
        string hireDate,
        string jobTitle,
        string employmentStatus,
        string disciplinaryRecord,
        double leaveBalance,
        string payslipPdf,
        string employeePersonnelRecord)
    {
        BaseSalaryAmount = baseSalaryAmount;
        AnnualBonusAmount = annualBonusAmount;
        OvertimePay = overtimePay;
        EquityGrantUnits = equityGrantUnits;
        BenefitsEnrolment = benefitsEnrolment;
        PensionContributionAmount = pensionContributionAmount;
        HireDate = hireDate;
        JobTitle = jobTitle;
        EmploymentStatus = employmentStatus;
        DisciplinaryRecord = disciplinaryRecord;
        LeaveBalance = leaveBalance;
        PayslipPdf = payslipPdf;
        EmployeePersonnelRecord = employeePersonnelRecord;
    }
}
