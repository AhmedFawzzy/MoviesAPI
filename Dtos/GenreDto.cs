using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Dtos
{
    public class GenreDto
    {
        [Required]
        public string Name { get; set; }
    }
}
