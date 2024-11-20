using Movies_project.BLL.Dtos.DirectorDtos;
using Movies_project.BLL.Dtos.MovieDtos;

namespace Movies_project.DAL.Repositories.Interfaces
{
    public interface IDirectoryRepository
    {
        bool Add(CreateDirectoryDto dto);
        bool Update(UpdateDirectorDto dto);
        bool Delete(int id);
    }
}
