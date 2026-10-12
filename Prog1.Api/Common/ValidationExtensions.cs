using FluentValidation;

namespace Prog1.Api.Common;

public static class ValidationExtensions
{
    
    public static IServiceCollection AddfluentValidationConfig(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<Program>();
        return services;
    }
}
