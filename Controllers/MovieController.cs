using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Dtos;
using MoviesAPI.Repositories;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            List<Movie> All = _movieService.AllMovies();
            return Ok(All);

        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var g = _movieService.Get(id);
            return Ok(g);
        }

        [HttpPost]
        public IActionResult Create(MovieDto movie)
        {
            _movieService.Create(movie);
            return Ok(movie);

        }


        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, MovieDto movie)
        {
            _movieService.Update(id, movie);
            return Ok(movie);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteById(int id)
        {

            _movieService.Delete(id);
            return Ok(id);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{
        //    var mov = await _Context.moviess./*Include(o=>o.Genre.Name).*/Select(o => new MovieDto {
        //        Title = o.Title,
        //        Year = o.Year,
        //        Rate = o.Rate,
        //        GenreId = o.GenreId,
        //        StoreLine = o.StoreLine,
        //    }).ToListAsync();
        //    return Ok(mov);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(MovieDto Dto)
        //{
        //    Movie movie = new Movie
        //    {
        //        Title = Dto.Title,
        //        Year = Dto.Year,
        //        StoreLine = Dto.StoreLine,
        //        Rate = Dto.Rate,
        //        GenreId = Dto.GenreId,
        //    };
        //    await _Context.moviess.AddAsync(movie);
        //    _Context.SaveChanges();
        //    return Ok(movie);
        //    //_Context.movies.AddAsync(Dto);
        //}

        //[HttpPut]
        //[Route("{id}")]
        //public async Task<IActionResult> Edit(int id, MovieDto dto)
        //{
        //    var mov = _Context.moviess.FirstOrDefault(o => o.Id == id);
        //    if (mov == null) {
        //        return BadRequest($"Not Movie Have This ID : {id}");
        //    }
        //    mov.Title = dto.Title;
        //    mov.Year = dto.Year;
        //    mov.StoreLine = dto.StoreLine;
        //    _Context.SaveChanges();
        //    return Ok(mov);
        //}
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete (int id)
        //{
        //    var movie = _Context.moviess.FirstOrDefault(o=>o.Id == id);
        //    if (movie == null) { 
        //    return NotFound();
        //    }
        //    _Context.moviess.Remove(movie);
        //    _Context.SaveChanges();
        //    return Ok(movie);
        //}


    } 
}
