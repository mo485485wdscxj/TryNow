using Microsoft.AspNetCore.Mvc;
using Movies_project.BLL.Dtos.DirectorDtos;
using Movies_project.BLL.Dtos.MovieDtos;
using Movies_project.DAL.Repositories.Interfaces;

namespace Movies_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectoryRepository _movieRepository;

        public DirectorController(IDirectoryRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpPost]
        public IActionResult Create(CreateDirectoryDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _movieRepository.Add(dto);

            if (!result)
                return BadRequest();
            return Created();
        }

        [HttpPut]
        public IActionResult Update(UpdateDirectorDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _movieRepository.Update(dto);

            if (!result)
                return BadRequest();
            return Accepted();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var result = _movieRepository.Delete(id);

            if (!result)
                return BadRequest();
            return NoContent();
        }
    }
}
