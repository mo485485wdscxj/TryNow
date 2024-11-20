using Movies_project.BLL.Dtos.CategoryDtos;
using Movies_project.BLL.Dtos.NationalityDtos;

namespace Movies_project.DAL.Repositories.Interfaces
{
    public interface INationaityRepository
    {
        bool Add(CreateNationalityDto dto);
        bool Delete(int id);
    }
}
