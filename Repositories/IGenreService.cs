using MoviesAPI.Dtos;

namespace MoviesAPI.Repositories
{
    public interface IGenreService<Genre>
    {
        List<Genre> AllGenre();

        Genre Get(int id);
        Genre Create(GenreDto genre);
        Genre Update(int id ,GenreDto genre);

        Genre Delete(int id);





    }
}
