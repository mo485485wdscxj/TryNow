using Movies_project.BLL.Dtos.CategoryDtos;

namespace Movies_project.DAL.Repositories
{
    public interface ICategoryRepository
    {
        bool Add(CreateCategoryDto dto);
        bool Update(int id,CreateCategoryDto dto);

    }
}
// fady