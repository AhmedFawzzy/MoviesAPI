using Microsoft.EntityFrameworkCore;
using MoviesAPI.Dtos;

namespace MoviesAPI.Repositories
{
    public class MovieService : IMovieService
    {

        private readonly DataContext _Context;
        public MovieService(DataContext Context)
        {
            _Context = Context;
        }
        public List<Movie> AllMovies()
        {
            List<Movie> movie = _Context.movies.ToList();
            return movie ;
        }

        public MovieWithGenre Get(int id)
        {
            Movie m = _Context.movies.Include(p=>p.Genre).SingleOrDefault(p => p.Id == id);
            MovieWithGenre Dto = new MovieWithGenre();
            Dto.GenreName= m.Genre.Name ;
            Dto.MovieName=m.Title;
            return (Dto);
        }
        public Movie Create(MovieDto Movie)
        {
            Movie Movie1 = new Movie
            {
                Title = Movie.Title,
                Year = Movie.Year,
                Rate = Movie.Rate,
                StoreLine = Movie.StoreLine,
            };
            _Context.movies.Add(Movie1);
            _Context.SaveChanges();
            return (Movie1);

        }
        public Movie Update(int id, MovieDto Movie)
        {
            var g1 = _Context.movies.SingleOrDefault(g => g.Id == id);
            g1.Title = Movie.Title;
            g1.Rate = Movie.Rate;
            _Context.SaveChanges();
            return g1;
        }

        public Movie Delete(int id)
        {
            var g = _Context.movies.SingleOrDefault(p => p.Id == id);
            _Context.movies.Remove(g);
            _Context.SaveChanges();
            return (g);
        }
    }
}
