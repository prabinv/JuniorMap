using Junior.Mapping.Common;

namespace Junior.Mapping.Mapper
{
	/// <summary>
	/// Represents a way to automatically configure mappings by convention.
	/// </summary>
	public interface IMapperConvention
	{
		/// <summary>
		/// Applies mappings to the specified mapping configuration.
		/// </summary>
		/// <typeparam name="TSource">The source type.</typeparam>
		/// <typeparam name="TTarget">The target type.</typeparam>
		/// <param name="propertyFinder">An <see cref="IConventionEligiblePropertyFinder"/> with which to find eligible properties.</param>
		/// <param name="configuration">A mapper configuration to which mappings will be applied.</param>
		void Apply<TSource, TTarget>(IConventionEligiblePropertyFinder propertyFinder, MapperConfiguration<TSource, TTarget> configuration);
	}
}