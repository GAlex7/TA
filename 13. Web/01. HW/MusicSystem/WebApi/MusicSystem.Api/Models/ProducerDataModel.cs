namespace MusicSystem.Api.Models
{
    using System.ComponentModel.DataAnnotations;

    using Infrastructure.Mapping;
    using MusicSystem.Models;

    public class ProducerDataModel : IMapFrom<Producer>
    {
        [Required]
        public string Name { get; set; }
    }
}