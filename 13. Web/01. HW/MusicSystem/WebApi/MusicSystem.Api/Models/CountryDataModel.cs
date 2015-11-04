namespace MusicSystem.Api.Models
{
    using System.ComponentModel.DataAnnotations;

    using Infrastructure.Mapping;
    using MusicSystem.Models;

    public class CountryDataModel : IMapFrom<Country>
    {
        [Required]
        public string Name { get; set; }
    }
}