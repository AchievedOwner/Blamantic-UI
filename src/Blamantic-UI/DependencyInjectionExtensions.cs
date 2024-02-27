namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjectionExtensions
{
	public static IServiceCollection AddBlamanticUI(this IServiceCollection services)
	{
		return services.AddComponentBuilder();
	}
}
