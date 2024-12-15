using BorderingCountryQuiz;
using BorderingCountryQuiz.CountriesJSON;


var app = new App();
foreach (var country in CountryWithNeighbors.GetCountries())
{
    app.AddCountry(country.country, country.GetNeighbors());
}

var countryCodeConsole = new CountryCodeConsole("Velg et land: ");
var countryName = countryCodeConsole.AskForCountry();
Console.WriteLine(countryName);