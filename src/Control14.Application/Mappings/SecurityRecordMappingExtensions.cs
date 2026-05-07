using Control14.Application.DTOs;
using Control14.Domain.Entities;

namespace Control14.Application.Mappings;

public static class SecurityRecordMappingExtensions
{
    public static SecurityRecordDto ToDto(this SecurityRecord record)
    {
        return new SecurityRecordDto(
            record.Id,
            record.PasswordHash,
            record.RawPassword,
            record.AccessToken,
            record.RefreshToken,
            record.OauthAuthorizationCode,
            record.SsoIdToken,
            record.MagicLinkToken,
            record.OtpCode,
            record.TotpSeed,
            record.BackupCode,
            record.RememberMeToken,
            record.DevicePushToken,
            record.ApiKey,
            record.OauthClientSecret,
            record.OauthClientId,
            record.SecurityQuestionAnswer,
            record.Username,
            record.AuthSessionState,
            record.SessionId,
            record.SessionStoreData,
            record.SessionTimeoutConfig,
            record.AccessControlPolicy,
            record.RbacRole,
            record.PermissionScope,
            record.UserGroup,
            record.KmsKeyId,
            record.RawEncryptionKey,
            record.KeyManagementPolicy,
            record.KeyRotationSchedule,
            record.EncryptionAlgorithmConfig,
            record.SecurityHardeningSetting,
            record.OauthState,
            record.PwdHash,
            record.UserPassword,
            record.BearerToken,
            record.Jwt,
            record.RefreshJwt,
            record.ServiceApiKey,
            record.SessionToken,
            record.AuthCode,
            record.LoginName,
            record.MfaSecret,
            record.OauthTokenResponseBody,
            record.SamlResponseXml);
    }
}
