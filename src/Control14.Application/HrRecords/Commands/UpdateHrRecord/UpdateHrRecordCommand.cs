using System.Text.Json.Serialization;
using Control14.Application.DTOs;
using MediatR;

namespace Control14.Application.HrRecords.Commands.UpdateHrRecord;

public record UpdateHrRecordCommand(
    Guid Id,
    [property: JsonPropertyName("base_salary_amount")] double BaseSalaryAmount,
    [property: JsonPropertyName("annual_bonus_amount")] double AnnualBonusAmount,
    [property: JsonPropertyName("overtime_pay")] double OvertimePay,
    [property: JsonPropertyName("equity_grant_units")] double EquityGrantUnits,
    [property: JsonPropertyName("benefits_enrolment")] string BenefitsEnrolment,
    [property: JsonPropertyName("pension_contribution_amount")] double PensionContributionAmount,
    [property: JsonPropertyName("hire_date")] string HireDate,
    [property: JsonPropertyName("job_title")] string JobTitle,
    [property: JsonPropertyName("employment_status")] string EmploymentStatus,
    [property: JsonPropertyName("disciplinary_record")] string DisciplinaryRecord,
    [property: JsonPropertyName("leave_balance")] double LeaveBalance,
    [property: JsonPropertyName("payslip_pdf")] string PayslipPdf,
    [property: JsonPropertyName("employee_personnel_record")] string EmployeePersonnelRecord) : IRequest<HrRecordDto?>;
