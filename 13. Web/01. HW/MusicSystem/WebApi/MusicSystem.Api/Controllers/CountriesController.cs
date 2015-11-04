namespace MusicSystem.Api.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using AutoMapper.QueryableExtensions;
    using Models;
    using Services;
    using Services.Contracts;

    public class CountriesController : ApiController
    {
        private readonly ICountriesService countries;

        public CountriesController()
        {
            this.countries = new CountriesService();
        }

        public IHttpActionResult Get()
        {
            var result = this.countries
                .All()
                .ToList();

            return this.Ok(result);
        }

        public IHttpActionResult Get(int id)
        {
            if (id < 0)
            {
                return this.BadRequest("Country can not be negative");
            }

            var result = this.countries
                .All()
                .Where(c => c.Id == id)
                .ProjectTo<CountryDataModel>()
                .FirstOrDefault();

            if (result == null)
            {
                return this.NotFound();
            }

            return this.Ok(result);
        }

        public IHttpActionResult Post(CountryDataModel country)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var createdCountryId = this.countries.Add(country.Name);

            return this.Ok(createdCountryId);
        }
    }
}
