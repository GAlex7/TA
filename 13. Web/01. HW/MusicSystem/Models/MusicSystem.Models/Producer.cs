namespace MusicSystem.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Producer
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
