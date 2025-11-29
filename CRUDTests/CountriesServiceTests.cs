using ServiceContracts;
using ServiceContracts.DTO;

namespace CRUDTests;

public class CountriesServiceTests
{
    private ICountriesService _countriesService;
    private CountryAddRequest _countryAddRequest;

    [SetUp]
    public void Setup()
    {
        _countriesService = new CountriesService();
        _countryAddRequest = new CountryAddRequest
        {
            CountryName = "Spain"
        };
    }

    [Test]
    public void Test1()
    {

        var result = _countriesService.AddCountry(_countryAddRequest);
        Assert.That(result, Is.Not.Null);
    }
}

public class CountriesService : ICountriesService
{
    public CountryResponse AddCountry(CountryAddRequest? countryAddRequest)
    {
        return new CountryResponse();
    }
}