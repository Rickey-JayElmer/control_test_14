namespace Control14.Domain.Entities;

public class SecurityRecord
{
    public Guid Id { get; private set; }
    public string PasswordHash { get; private set; } = string.Empty;
    public string RawPassword { get; private set; } = string.Empty;
    public string AccessToken { get; private set; } = string.Empty;
    public string RefreshToken { get; private set; } = string.Empty;
    public string OauthAuthorizationCode { get; private set; } = string.Empty;
    public string SsoIdToken { get; private set; } = string.Empty;
    public string MagicLinkToken { get; private set; } = string.Empty;
    public string OtpCode { get; private set; } = string.Empty;
    public string TotpSeed { get; private set; } = string.Empty;
    public string BackupCode { get; private set; } = string.Empty;
    public string RememberMeToken { get; private set; } = string.Empty;
    public string DevicePushToken { get; private set; } = string.Empty;
    public string ApiKey { get; private set; } = string.Empty;
    public string OauthClientSecret { get; private set; } = string.Empty;
    public string OauthClientId { get; private set; } = string.Empty;
    public string SecurityQuestionAnswer { get; private set; } = string.Empty;
    public string Username { get; private set; } = string.Empty;
    public string AuthSessionState { get; private set; } = string.Empty;
    public string SessionId { get; private set; } = string.Empty;
    public string SessionStoreData { get; private set; } = string.Empty;
    public string SessionTimeoutConfig { get; private set; } = string.Empty;
    public string AccessControlPolicy { get; private set; } = string.Empty;
    public string RbacRole { get; private set; } = string.Empty;
    public string PermissionScope { get; private set; } = string.Empty;
    public string UserGroup { get; private set; } = string.Empty;
    public string KmsKeyId { get; private set; } = string.Empty;
    public string RawEncryptionKey { get; private set; } = string.Empty;
    public string KeyManagementPolicy { get; private set; } = string.Empty;
    public string KeyRotationSchedule { get; private set; } = string.Empty;
    public string EncryptionAlgorithmConfig { get; private set; } = string.Empty;
    public string SecurityHardeningSetting { get; private set; } = string.Empty;
    public string OauthState { get; private set; } = string.Empty;
    public string PwdHash { get; private set; } = string.Empty;
    public string UserPassword { get; private set; } = string.Empty;
    public string BearerToken { get; private set; } = string.Empty;
    public string Jwt { get; private set; } = string.Empty;
    public string RefreshJwt { get; private set; } = string.Empty;
    public string ServiceApiKey { get; private set; } = string.Empty;
    public string SessionToken { get; private set; } = string.Empty;
    public string AuthCode { get; private set; } = string.Empty;
    public string LoginName { get; private set; } = string.Empty;
    public string MfaSecret { get; private set; } = string.Empty;
    public string OauthTokenResponseBody { get; private set; } = string.Empty;
    public string SamlResponseXml { get; private set; } = string.Empty;

    private SecurityRecord() { }

    public static SecurityRecord Create(
        string passwordHash,
        string rawPassword,
        string accessToken,
        string refreshToken,
        string oauthAuthorizationCode,
        string ssoIdToken,
        string magicLinkToken,
        string otpCode,
        string totpSeed,
        string backupCode,
        string rememberMeToken,
        string devicePushToken,
        string apiKey,
        string oauthClientSecret,
        string oauthClientId,
        string securityQuestionAnswer,
        string username,
        string authSessionState,
        string sessionId,
        string sessionStoreData,
        string sessionTimeoutConfig,
        string accessControlPolicy,
        string rbacRole,
        string permissionScope,
        string userGroup,
        string kmsKeyId,
        string rawEncryptionKey,
        string keyManagementPolicy,
        string keyRotationSchedule,
        string encryptionAlgorithmConfig,
        string securityHardeningSetting,
        string oauthState,
        string pwdHash,
        string userPassword,
        string bearerToken,
        string jwt,
        string refreshJwt,
        string serviceApiKey,
        string sessionToken,
        string authCode,
        string loginName,
        string mfaSecret,
        string oauthTokenResponseBody,
        string samlResponseXml)
    {
        return new SecurityRecord
        {
            Id = Guid.NewGuid(),
            PasswordHash = passwordHash,
            RawPassword = rawPassword,
            AccessToken = accessToken,
            RefreshToken = refreshToken,
            OauthAuthorizationCode = oauthAuthorizationCode,
            SsoIdToken = ssoIdToken,
            MagicLinkToken = magicLinkToken,
            OtpCode = otpCode,
            TotpSeed = totpSeed,
            BackupCode = backupCode,
            RememberMeToken = rememberMeToken,
            DevicePushToken = devicePushToken,
            ApiKey = apiKey,
            OauthClientSecret = oauthClientSecret,
            OauthClientId = oauthClientId,
            SecurityQuestionAnswer = securityQuestionAnswer,
            Username = username,
            AuthSessionState = authSessionState,
            SessionId = sessionId,
            SessionStoreData = sessionStoreData,
            SessionTimeoutConfig = sessionTimeoutConfig,
            AccessControlPolicy = accessControlPolicy,
            RbacRole = rbacRole,
            PermissionScope = permissionScope,
            UserGroup = userGroup,
            KmsKeyId = kmsKeyId,
            RawEncryptionKey = rawEncryptionKey,
            KeyManagementPolicy = keyManagementPolicy,
            KeyRotationSchedule = keyRotationSchedule,
            EncryptionAlgorithmConfig = encryptionAlgorithmConfig,
            SecurityHardeningSetting = securityHardeningSetting,
            OauthState = oauthState,
            PwdHash = pwdHash,
            UserPassword = userPassword,
            BearerToken = bearerToken,
            Jwt = jwt,
            RefreshJwt = refreshJwt,
            ServiceApiKey = serviceApiKey,
            SessionToken = sessionToken,
            AuthCode = authCode,
            LoginName = loginName,
            MfaSecret = mfaSecret,
            OauthTokenResponseBody = oauthTokenResponseBody,
            SamlResponseXml = samlResponseXml
        };
    }

    public void Update(
        string passwordHash,
        string rawPassword,
        string accessToken,
        string refreshToken,
        string oauthAuthorizationCode,
        string ssoIdToken,
        string magicLinkToken,
        string otpCode,
        string totpSeed,
        string backupCode,
        string rememberMeToken,
        string devicePushToken,
        string apiKey,
        string oauthClientSecret,
        string oauthClientId,
        string securityQuestionAnswer,
        string username,
        string authSessionState,
        string sessionId,
        string sessionStoreData,
        string sessionTimeoutConfig,
        string accessControlPolicy,
        string rbacRole,
        string permissionScope,
        string userGroup,
        string kmsKeyId,
        string rawEncryptionKey,
        string keyManagementPolicy,
        string keyRotationSchedule,
        string encryptionAlgorithmConfig,
        string securityHardeningSetting,
        string oauthState,
        string pwdHash,
        string userPassword,
        string bearerToken,
        string jwt,
        string refreshJwt,
        string serviceApiKey,
        string sessionToken,
        string authCode,
        string loginName,
        string mfaSecret,
        string oauthTokenResponseBody,
        string samlResponseXml)
    {
        PasswordHash = passwordHash;
        RawPassword = rawPassword;
        AccessToken = accessToken;
        RefreshToken = refreshToken;
        OauthAuthorizationCode = oauthAuthorizationCode;
        SsoIdToken = ssoIdToken;
        MagicLinkToken = magicLinkToken;
        OtpCode = otpCode;
        TotpSeed = totpSeed;
        BackupCode = backupCode;
        RememberMeToken = rememberMeToken;
        DevicePushToken = devicePushToken;
        ApiKey = apiKey;
        OauthClientSecret = oauthClientSecret;
        OauthClientId = oauthClientId;
        SecurityQuestionAnswer = securityQuestionAnswer;
        Username = username;
        AuthSessionState = authSessionState;
        SessionId = sessionId;
        SessionStoreData = sessionStoreData;
        SessionTimeoutConfig = sessionTimeoutConfig;
        AccessControlPolicy = accessControlPolicy;
        RbacRole = rbacRole;
        PermissionScope = permissionScope;
        UserGroup = userGroup;
        KmsKeyId = kmsKeyId;
        RawEncryptionKey = rawEncryptionKey;
        KeyManagementPolicy = keyManagementPolicy;
        KeyRotationSchedule = keyRotationSchedule;
        EncryptionAlgorithmConfig = encryptionAlgorithmConfig;
        SecurityHardeningSetting = securityHardeningSetting;
        OauthState = oauthState;
        PwdHash = pwdHash;
        UserPassword = userPassword;
        BearerToken = bearerToken;
        Jwt = jwt;
        RefreshJwt = refreshJwt;
        ServiceApiKey = serviceApiKey;
        SessionToken = sessionToken;
        AuthCode = authCode;
        LoginName = loginName;
        MfaSecret = mfaSecret;
        OauthTokenResponseBody = oauthTokenResponseBody;
        SamlResponseXml = samlResponseXml;
    }
}
