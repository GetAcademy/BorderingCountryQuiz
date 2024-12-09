namespace BorderingCountryQuiz.CountriesJSON
{
    public class CountryWithNeighbors
    {
        public string country { get; set; }
        public Neighbor[] neighbors { get; set; }


        public string[] GetNeighbors()
        {
            return neighbors
                .Where(c => c.borderType.Contains("land"))
                .Select(n => n.country)
                .ToArray();
        }
    }

    public class Neighbor
    {
        public string country { get; set; }
        public string borderType { get; set; }
    }

}
