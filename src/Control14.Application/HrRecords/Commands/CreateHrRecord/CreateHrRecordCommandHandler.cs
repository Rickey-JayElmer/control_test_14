using Control14.Application.Interfaces;
using Control14.Domain.Entities;
using MediatR;

namespace Control14.Application.HrRecords.Commands.CreateHrRecord;

public class CreateHrRecordCommandHandler : IRequestHandler<CreateHrRecordCommand, Guid>
{
    private readonly IHrRecordRepository _repository;

    public CreateHrRecordCommandHandler(IHrRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateHrRecordCommand request, CancellationToken cancellationToken)
    {
        var record = HrRecord.Create(
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

        await _repository.AddAsync(record, cancellationToken);

        return record.Id;
    }
}
