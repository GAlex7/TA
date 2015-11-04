namespace MusicSystem.Services.Contracts
{
    using System.Linq;

    using Models;

    public interface ICountriesService
    {
        IQueryable<Country> All();

        int Add(string name);
    }
}
