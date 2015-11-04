namespace MusicSystem.Api.Models
{
    using System.ComponentModel.DataAnnotations;

    using Infrastructure.Mapping;
    using MusicSystem.Models;

    public class AlbumDataModel : IMapFrom<Album>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int ProducerId { get; set; }

        [Required]
        public int[] SongIds { get; set; }

        [Required]
        public int[] ArtistIds { get; set; }
    }
}