using Control14.Application.Interfaces;
using Control14.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Control14.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IAiInferenceRecordRepository, InMemoryAiInferenceRecordRepository>();
        services.AddSingleton<IDeviceTelemetryRecordRepository, InMemoryDeviceTelemetryRecordRepository>();
        services.AddSingleton<IFinancialPaymentRecordRepository, InMemoryFinancialPaymentRecordRepository>();
        services.AddSingleton<IGeolocationRecordRepository, InMemoryGeolocationRecordRepository>();
        services.AddSingleton<IHrRecordRepository, InMemoryHrRecordRepository>();
        services.AddSingleton<ILegalRecordRepository, InMemoryLegalRecordRepository>();
        services.AddSingleton<INetworkRequestRecordRepository, InMemoryNetworkRequestRecordRepository>();
        services.AddSingleton<IOrganizationRecordRepository, InMemoryOrganizationRecordRepository>();
        services.AddSingleton<IPersonalRecordRepository, InMemoryPersonalRecordRepository>();
        services.AddSingleton<ISecurityRecordRepository, InMemorySecurityRecordRepository>();
        return services;
    }
}
