using MoviesAPI.Dtos;

namespace MoviesAPI.Repositories
{
    public interface IMovieService
    {
        List<Movie> AllMovies();

        MovieWithGenre Get(int id);
        Movie Create(MovieDto Movie);
        Movie Update(int id, MovieDto Movie);

        Movie Delete(int id);
    }
}
