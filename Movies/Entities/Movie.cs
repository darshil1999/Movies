using System.ComponentModel.DataAnnotations;

namespace Movies.Entities
{
    public class Movie
    {

        public int MovieId { get; set; }

        [Required(ErrorMessage = "Movie name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Movie Year is required.")]
        [Range(1830, int.MaxValue, ErrorMessage ="Year can not be less than 1830.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Movie Rating is required.")]
        [Range(1,5, ErrorMessage = "Rating must be form 1 to 5 only.")]
        public int? Rating { get; set; }
    }
}
