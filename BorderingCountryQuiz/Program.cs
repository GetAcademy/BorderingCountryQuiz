using System.Text.Json;using BorderingCountryQuiz;
using BorderingCountryQuiz.CountriesJSON;

var json = File.ReadAllText("CountriesJSON/countries.json");
var countries = JsonSerializer.Deserialize<CountryWithNeighbors[]>(json);
var app = new App();

foreach (var country in countries)
{
    var neighbors = country.neighbors
        .Where(c => c.borderType.Contains("land"))
        .Select(n => n.country);
    app.AddCountry(country.country, neighbors);
}

var countryCodeConsole = new CountryCodeConsole("Velg et land: ");
var countryName = countryCodeConsole.AskForCountry();
Console.WriteLine(countryName);