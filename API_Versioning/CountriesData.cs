using API_Versioning.Models.Domain;

namespace API_Versioning
{
    public static class CountriesData
    {
        public static List<Country> Get()
        {
            var countries = new[]
            {
                new { Id = 1, Name = "United States" },
                new { Id = 2, Name = "Iran"}
            };
            return countries.Select(c => new Country { Id = c.Id, Name = c.Name }).ToList();
        }
    }
}
