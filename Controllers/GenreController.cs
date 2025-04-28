using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoviesAPI.Dtos;
using MoviesAPI.Repositories;

namespace MoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreService<Genre> _genreService;
        public GenreController(IGenreService<Genre> genreService)
        {
            _genreService = genreService;
        }

        [HttpGet]
        public IActionResult Get() { 
         
            List<Genre> All = _genreService.AllGenre();
            return Ok(All);

        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id) { 
           var g = _genreService.Get(id);
           return Ok(g);
        }

        [HttpPost]
        public IActionResult Create(GenreDto genre)
        {
            _genreService.Create(genre);
            return Ok(genre);

        }


        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id,GenreDto genre) { 
            _genreService.Update(id, genre);
            return Ok(genre);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteById(int id) { 
        
        _genreService.Delete(id);
            return Ok(id);
                }




        #region OlD Crud
        //private readonly DataContext _Context;
        //public GenreController(DataContext Context)
        //{
        //    _Context = Context;
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetAll ()
        //{
        //   List<Genre> genre = await _Context.genres.ToListAsync();
        //   return Ok(genre);
        //}

        //[HttpGet]
        //public async Task<IActionResult> GetAllWithSpecficParameter()
        //{

        //        var genre = await _Context.genres.Select(o=> new GenreDto {Name = o.Name}).ToListAsync();



        //    return Ok(genre);
        //}

        //[HttpPost]
        //public async Task<IActionResult> Create(GenreDto dto)
        //{
        //    Genre genre = new Genre { Name = dto.Name };
        //    await _Context.genres.AddAsync(genre);
        //    _Context.SaveChanges();
        //    return Ok(genre);
        //}

        //[HttpPut]
        //[Route("{id:int}")]
        //public async Task<IActionResult> Update(int id ,GenreDto dto)
        //{
        //    Genre gen = _Context.genres.FirstOrDefault(p=>p.Id == id);
        //    if (gen == null) {
        //        return BadRequest($"Not Genre Have This Id : {id}");
        //    }
        //    gen.Name = dto.Name;
        //    _Context.SaveChanges();
        //    return Ok(gen);
        //}

        ////[HttpPut]
        ////[Route("{id:int}")]
        ////public async Task<IActionResult> UpdateWithModel(int id ,Genre Gen)
        ////{
        ////    Genre gen = _Context.genres.FirstOrDefault(p=>p.Id == id);
        ////    if (gen == null) {
        ////        return BadRequest($"Not Genre Have This Id : {id}");
        ////    }
        ////    gen=Gen;

        ////    _Context.SaveChanges();
        ////    return Ok(gen);
        ////}

        //[HttpDelete]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    Genre gen = _Context.genres.FirstOrDefault(p=>p.Id == id);
        //    _Context.genres.Remove(gen);
        //    _Context.SaveChanges();
        //    return Ok(gen);
        //}
        #endregion

    }
}
