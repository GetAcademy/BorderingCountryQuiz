namespace BorderingCountryQuiz.CountriesJSON
{
    public class CountryWithNeighbors
    {
        public string country { get; set; }
        public Neighbor[] neighbors { get; set; }
    }

    public class Neighbor
    {
        public string country { get; set; }
        public string borderType { get; set; }
    }

}
