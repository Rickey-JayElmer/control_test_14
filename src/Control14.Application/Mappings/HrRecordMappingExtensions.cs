using Control14.Application.DTOs;
using Control14.Domain.Entities;

namespace Control14.Application.Mappings;

public static class HrRecordMappingExtensions
{
    public static HrRecordDto ToDto(this HrRecord record)
    {
        return new HrRecordDto(
            record.Id,
            record.BaseSalaryAmount,
            record.AnnualBonusAmount,
            record.OvertimePay,
            record.EquityGrantUnits,
            record.BenefitsEnrolment,
            record.PensionContributionAmount,
            record.HireDate,
            record.JobTitle,
            record.EmploymentStatus,
            record.DisciplinaryRecord,
            record.LeaveBalance,
            record.PayslipPdf,
            record.EmployeePersonnelRecord);
    }
}
