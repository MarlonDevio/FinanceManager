using ServiceContracts.DTO;

namespace ServiceContracts;

/// <summary>
/// Represents business logic for manipulating Country entity
/// </summary>
public interface ICountriesService
{
  /// <summary>
  /// Adds a country object to countries list
  /// </summary>
  /// <param name="countryAddRequest"><see cref="CountryAddRequest"/></param>
  /// <returns><see cref="CountryResponse"/></returns>
  CountryResponse AddCountry(CountryAddRequest? countryAddRequest);
}
