namespace BorderingCountryQuiz
{
    internal class App
    {
        public App()
        {
            
        }

        public void AddCountry(string countryName, string[] neighboringCountryNames)
        {
            
        }

        public void AskForNeighborsOfRandomCountry()
        {
            var countryCodeConsole = new CountryCodeConsole("Velg et land: ");
            var countryName = countryCodeConsole.AskForCountry();
            Console.WriteLine(countryName);
        }
    }
}
