namespace MusicSystem.Api.Models
{
    using System.ComponentModel.DataAnnotations;

    using Infrastructure.Mapping;
    using MusicSystem.Models;

    public class ArtistDataModel : IMapFrom<Artist>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}