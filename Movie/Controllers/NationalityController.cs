using Microsoft.AspNetCore.Mvc;
using Movies_project.BLL.Dtos.CategoryDtos;
using Movies_project.BLL.Dtos.NationalityDtos;
using Movies_project.DAL.Repositories.Interfaces;

namespace Movies_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : ControllerBase
    {
        private readonly INationaityRepository _NationailtyRepository;

        public NationalityController(INationaityRepository NationailtyRepository)
        {
            _NationailtyRepository = NationailtyRepository;
        }


        [HttpPost]
        public IActionResult Create(CreateNationalityDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _NationailtyRepository.Add(dto);

            if (!result)
                return BadRequest();
            return Created();
        }

        [HttpDelete]
        public IActionResult Remove(int id)
        {
            var result = _NationailtyRepository.Delete(id);
            if (!result)
                return BadRequest();
            return Accepted();
        }
    }
}
