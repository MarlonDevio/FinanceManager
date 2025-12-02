using Entities;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services;

public class CountriesService : ICountriesService
{
    private readonly List<Country> _countries = new();

    public CountryResponse AddCountry(CountryAddRequest? countryAddRequest)
    {
        ArgumentNullException.ThrowIfNull(countryAddRequest);

        if (countryAddRequest.CountryName is null)
        {
            throw new ArgumentException(message: "CountryName should not be null");
        }

        bool countryExists = _countries.Any(c =>
            string.Equals(c.CountryName, countryAddRequest.CountryName, StringComparison.OrdinalIgnoreCase));

        if (countryExists)
        {
            throw new ArgumentException("Country with the same name already exists!");
        }

        var country = countryAddRequest.ToCountry();
        country.CountryId = Guid.NewGuid();
        _countries.Add(country);

        return country.ToCountryResponse();
    }
}