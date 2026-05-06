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
        services.AddSingleton<IGeolocationRecordRepository, InMemoryGeolocationRecordRepository>();
        services.AddSingleton<INetworkRequestRecordRepository, InMemoryNetworkRequestRecordRepository>();
        services.AddSingleton<IFinancialPaymentRecordRepository, InMemoryFinancialPaymentRecordRepository>();
        return services;
    }
}
