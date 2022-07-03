using MoviesAPI.Attributes;
using MoviesAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.DTOs
{
    public class MovieDto
    {
        [Required]
        [MaxLength(255)]
        public string? Title { get; set; }

        [ReleaseDate]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public EGenre Genre { get; set; }

        [MaxLength(1024)]
        public string? Description { get; set; }

        [ImdbSize]
        public double Imdb { get; set; }

        public long Viewed { get; set; }

    }
}

