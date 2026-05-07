using Control14.Application.Interfaces;
using Control14.Domain.Entities;
using MediatR;

namespace Control14.Application.SecurityRecords.Commands.CreateSecurityRecord;

public class CreateSecurityRecordCommandHandler : IRequestHandler<CreateSecurityRecordCommand, Guid>
{
    private readonly ISecurityRecordRepository _repository;

    public CreateSecurityRecordCommandHandler(ISecurityRecordRepository repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreateSecurityRecordCommand request, CancellationToken cancellationToken)
    {
        var record = SecurityRecord.Create(
            request.PasswordHash,
            request.RawPassword,
            request.AccessToken,
            request.RefreshToken,
            request.OauthAuthorizationCode,
            request.SsoIdToken,
            request.MagicLinkToken,
            request.OtpCode,
            request.TotpSeed,
            request.BackupCode,
            request.RememberMeToken,
            request.DevicePushToken,
            request.ApiKey,
            request.OauthClientSecret,
            request.OauthClientId,
            request.SecurityQuestionAnswer,
            request.Username,
            request.AuthSessionState,
            request.SessionId,
            request.SessionStoreData,
            request.SessionTimeoutConfig,
            request.AccessControlPolicy,
            request.RbacRole,
            request.PermissionScope,
            request.UserGroup,
            request.KmsKeyId,
            request.RawEncryptionKey,
            request.KeyManagementPolicy,
            request.KeyRotationSchedule,
            request.EncryptionAlgorithmConfig,
            request.SecurityHardeningSetting,
            request.OauthState,
            request.PwdHash,
            request.UserPassword,
            request.BearerToken,
            request.Jwt,
            request.RefreshJwt,
            request.ServiceApiKey,
            request.SessionToken,
            request.AuthCode,
            request.LoginName,
            request.MfaSecret,
            request.OauthTokenResponseBody,
            request.SamlResponseXml);

        await _repository.AddAsync(record, cancellationToken);

        return record.Id;
    }
}
