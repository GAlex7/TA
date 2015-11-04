namespace MusicSystem.Api.Models
{
    using System.ComponentModel.DataAnnotations;

    using Infrastructure.Mapping;
    using MusicSystem.Models;

    public class SongDataModel : IMapFrom<Song>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}