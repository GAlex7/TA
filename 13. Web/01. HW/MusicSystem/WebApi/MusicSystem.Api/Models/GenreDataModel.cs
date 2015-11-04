namespace MusicSystem.Api.Models
{
    using System.ComponentModel.DataAnnotations;

    using Infrastructure.Mapping;
    using MusicSystem.Models;

    public class GenreDataModel : IMapFrom<Genre>
    {
        [Required]
        public string Name { get; set; }
    }
}