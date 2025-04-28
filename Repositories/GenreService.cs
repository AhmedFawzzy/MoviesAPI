using Microsoft.EntityFrameworkCore;
using MoviesAPI.Dtos;

namespace MoviesAPI.Repositories
{
    public class GenreService : IGenreService<Genre>
    {
        private readonly DataContext _Context;
        public GenreService(DataContext Context)
        {
            _Context = Context;
        }
        public List<Genre> AllGenre()
        {
            return _Context.genres.ToList();
        }

        public Genre Get(int id)
        {
            return _Context.genres.SingleOrDefault(p => p.Id == id);
        }
        public Genre Create(GenreDto genre)
        {
           Genre genre1 = new Genre
           {
               Name = genre.Name,
           };
             _Context.genres.Add(genre1);
            _Context.SaveChanges();
            return (genre1);

        }
        public Genre Update(int id, GenreDto genre)
        {
            var g1 = _Context.genres.SingleOrDefault(g => g.Id ==  id);
            g1.Name = genre.Name;
            _Context.SaveChanges();
            return g1 ;
        }

        public Genre Delete(int id)
        {
            var g = _Context.genres.SingleOrDefault(p => p.Id == id);
            _Context.genres.Remove(g);
            _Context.SaveChanges();
            return (g);
        }

    }
}
