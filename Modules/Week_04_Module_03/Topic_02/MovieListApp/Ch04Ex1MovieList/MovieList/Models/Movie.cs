using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MovieList.Models
{
    // code based on page 141
    public class Movie
    {
        // EF will generate the primary key value
        public int MovieId { get; set; }
        [Required(ErrorMessage = "Please enter a movie name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter a Year.")]
        [Range(1889, 2999, ErrorMessage = "Year must be after 1889.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }

        // code based on page 161
        [Required(ErrorMessage = "Please enter a genre.")]
        public string GenreId { get; set; } = string.Empty;

        [ValidateNever]
        public Genre Genre { get; set; } = null!;

        // code based on page 173
        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}
