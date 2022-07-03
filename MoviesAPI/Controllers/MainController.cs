using Microsoft.AspNetCore.Mvc;
using MoviesAPI.DBContext;
using MoviesAPI.DTOs;
using MoviesAPI.Models;

namespace MoviesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class MainController : ControllerBase
    {
        private readonly ApplicationDBContext _dBContext;

        public MainController(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        [HttpGet("{Id}")]
        public IActionResult Get(Guid Id)
        {
            return Ok(_dBContext?.movies?.FirstOrDefault(x => x.Id == Id));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_dBContext.movies);
        }

        [HttpPost]
        public IActionResult Create([FromForm] MovieDto movieDto)
        {
            try
            {
                var movie = new Movie
                {
                    Title = movieDto.Title,
                    Description = movieDto.Description,
                    ReleaseDate = movieDto.ReleaseDate,
                    Genre = movieDto.Genre,
                    Viewed = movieDto.Viewed,
                    Imdb = movieDto.Imdb

                };
                _dBContext.Add(movie);
                _dBContext.SaveChanges();
                return Ok(movieDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
