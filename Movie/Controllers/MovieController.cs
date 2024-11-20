using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies_project.BLL.Dtos.MovieDtos;
using Movies_project.DAL.Repositories.Interfaces;

namespace Movies_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_movieRepository.getAll());
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_movieRepository.getById(id));
        }

        [HttpPost]
        public IActionResult Create(CreateMovieDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _movieRepository.Add(dto);

            if (!result)
                return BadRequest();
            return Created();
        }
    }
}
