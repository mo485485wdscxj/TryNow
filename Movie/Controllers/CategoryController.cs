using Microsoft.AspNetCore.Mvc;
using Movies_project.BLL.Dtos.CategoryDtos;
using Movies_project.BLL.Dtos.MovieDtos;
using Movies_project.DAL.Repositories.Interfaces;

namespace Movies_project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        [HttpPost]
        public IActionResult Create(CreateCategoryDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _categoryRepository.Add(dto);

            if (!result)
                return BadRequest();
            return Created();
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id,CreateCategoryDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _categoryRepository.Update(id,dto);

            if (!result)
                return BadRequest();
            return Accepted();
        }
    }
}
