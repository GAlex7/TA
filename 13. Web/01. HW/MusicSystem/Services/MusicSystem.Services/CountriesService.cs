namespace MusicSystem.Services
{
    using System.Linq;

    using Contracts;
    using Data;
    using Data.Repositories;
    using Models;

    public class CountriesService : ICountriesService
    {
        private readonly IRepository<Country> countries;

        public CountriesService()
        {
            var db = new MusicSystemDbContext();
            this.countries = new EfGenericRepository<Country>(db);
        }

        public int Add(string name)
        {
            var newCountry = new Country
            {
                Name = name
            };

            this.countries.Add(newCountry);
            this.countries.SaveChanges();

            return newCountry.Id;
        }

        public IQueryable<Country> All()
        {
            return this.countries.All().OrderBy(c => c.Name);
        }
    }
}
