using ServiceContracts;
using ServiceContracts.DTO;
using Services;

namespace CRUDTests;

public class CountriesServiceTests
{
    private ICountriesService _countriesService = new CountriesService();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AddCountry_NullCountry_ShouldThrowArgumentNullException()
    {
        CountryAddRequest? request = null;
        Assert.Throws<ArgumentNullException>(() => _countriesService.AddCountry(request));
    }

    [Test]
    public void AddCountry_NullCountryName_ShouldThrowArgumentException()
    {
        CountryAddRequest request = new CountryAddRequest()
        {
            CountryName = null
        };

        Assert.Throws<ArgumentException>(() => _countriesService.AddCountry(request));
    }

    
    [TestCase("Turkey", "turkey")]
    public void AddCountry_DuplicateName_ShouldThrowArgumentException(string value, string value2)
    {
        CountryAddRequest r1 = new CountryAddRequest { CountryName = value2 };
        CountryAddRequest r2 = new CountryAddRequest { CountryName = value };
        Assert.Throws<ArgumentException>(() =>
        {
            _countriesService.AddCountry(r1);
            _countriesService.AddCountry(r2);
        });
    }
}