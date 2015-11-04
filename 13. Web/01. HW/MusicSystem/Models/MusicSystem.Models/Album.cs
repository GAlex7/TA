namespace MusicSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Album
    {
        private IList<Artist> artists;
        private IList<Song> songs;

        public Album()
        {
            this.artists = new List<Artist>();
            this.songs = new List<Song>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        public int Year { get; set; }

        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public virtual Producer Producer { get; set; }

        public virtual IList<Artist> Artists
        {
            get { return this.artists; }
            set { this.artists = value; }
        }

        public virtual IList<Song> Songs
        {
            get { return this.songs; }
            set { this.songs = value; }
        }
    }
}
