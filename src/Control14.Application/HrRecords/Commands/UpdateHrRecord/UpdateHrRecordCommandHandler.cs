using Control14.Application.DTOs;
using Control14.Application.Interfaces;
using Control14.Application.Mappings;
using MediatR;

namespace Control14.Application.HrRecords.Commands.UpdateHrRecord;

public class UpdateHrRecordCommandHandler : IRequestHandler<UpdateHrRecordCommand, HrRecordDto?>
{
    private readonly IHrRecordRepository _repository;

    public UpdateHrRecordCommandHandler(IHrRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<HrRecordDto?> Handle(UpdateHrRecordCommand request, CancellationToken cancellationToken)
    {
        var record = await _repository.GetByIdAsync(request.Id, cancellationToken);

        if (record is null)
            return null;

        record.Update(
            request.BaseSalaryAmount,
            request.AnnualBonusAmount,
            request.OvertimePay,
            request.EquityGrantUnits,
            request.BenefitsEnrolment,
            request.PensionContributionAmount,
            request.HireDate,
            request.JobTitle,
            request.EmploymentStatus,
            request.DisciplinaryRecord,
            request.LeaveBalance,
            request.PayslipPdf,
            request.EmployeePersonnelRecord);

        await _repository.UpdateAsync(record, cancellationToken);

        return record.ToDto();
    }
}
