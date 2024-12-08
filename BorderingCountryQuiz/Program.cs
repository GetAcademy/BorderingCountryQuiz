using System.Text.Json;
using BorderingCountryQuiz.CountriesJSON;

var json = File.ReadAllText("CountriesJSON/countries.json");
var countries = JsonSerializer.Deserialize<CountryWithNeighbors[]>(json);

Console.WriteLine();