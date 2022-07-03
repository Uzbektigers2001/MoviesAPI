using MoviesAPI.Attributes;
using MoviesAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Models
{
    public class Movie
    {
        [Required]
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public EGenre Genre{ get; set; }
        public string? Description { get; set; }
        public double Imdb { get; set; }
        public long Viewed { get; set; }

    }
}

