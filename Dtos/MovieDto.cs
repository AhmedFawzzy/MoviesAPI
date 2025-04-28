using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MoviesAPI.Dtos
{
    public class MovieDto
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rate { get; set; }

        [MaxLength(2500)]
        public string StoreLine { get; set; }
        //public byte[] Poster { get; set; }

        [ForeignKey("Genre")]
        public byte GenreId { get; set; }
    }
}
